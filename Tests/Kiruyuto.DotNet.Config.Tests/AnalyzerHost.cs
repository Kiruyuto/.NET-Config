using System.Collections.Immutable;
using Basic.Reference.Assemblies;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.Diagnostics;

namespace Kiruyuto.DotNet.Config.Tests;

internal sealed class AnalyzerHost
{
    private readonly AnalyzerConfigSet _configurationSet;

    internal AnalyzerConfigOptionsResult ConfigurationOptions => _configurationSet.GlobalConfigOptions;

    internal AnalyzerHost(string configurationFileName)
    {
        var configurationPath = Path.GetFullPath(Path.Combine(AppContext.BaseDirectory, "Configurations", configurationFileName));
        var configuration = AnalyzerConfig.Parse(File.ReadAllText(configurationPath), configurationPath);

        _configurationSet = AnalyzerConfigSet.Create(ImmutableArray.Create(configuration));
    }

    internal Task<ImmutableArray<Diagnostic>> AnalyzeAsync(string source, DiagnosticAnalyzer analyzer)
    {
        var sourcePath = Path.Combine(AppContext.BaseDirectory, "TestCase.cs");
        var sourceOptions = _configurationSet.GetOptionsForSourcePath(sourcePath);

        var severities = ConfigurationOptions.TreeOptions.SetItems(sourceOptions.TreeOptions);
        var configurationDiagnostics = ConfigurationOptions.Diagnostics.AddRange(sourceOptions.Diagnostics);

        if (!configurationDiagnostics.IsEmpty)
        {
            throw new InvalidOperationException(
                "The analyzer configuration is invalid:" +
                Environment.NewLine +
                string.Join(Environment.NewLine, configurationDiagnostics.Select(static diagnostic => diagnostic.ToString()))
            );
        }

        var compilation = CSharpCompilation.Create(
            assemblyName: "AnalyzerTestCase",
            syntaxTrees: [CSharpSyntaxTree.ParseText(source, path: sourcePath)],
            references: Net110.References.All,
            options: new CSharpCompilationOptions(OutputKind.DynamicallyLinkedLibrary).WithSpecificDiagnosticOptions(severities)
        );

        var compilerErrors = compilation
            .GetDiagnostics()
            .Where(static diagnostic => diagnostic.Severity == DiagnosticSeverity.Error)
            .ToArray();

        if (compilerErrors.Length > 0)
        {
            throw new InvalidOperationException(
                "The test source does not compile:" +
                Environment.NewLine +
                string.Join(Environment.NewLine, compilerErrors.Select(static diagnostic => diagnostic.ToString()))
            );
        }

        return compilation
            .WithAnalyzers(
                analyzers: [analyzer],
                options: new AnalyzerOptions(additionalFiles: [], optionsProvider: new ConfigurationOptionsProvider(_configurationSet))
            )
            .GetAnalyzerDiagnosticsAsync();
    }

    private sealed class ConfigurationOptionsProvider(AnalyzerConfigSet configurationSet) : AnalyzerConfigOptionsProvider
    {
        public override AnalyzerConfigOptions GlobalOptions { get; } = new ConfigOptions(configurationSet.GlobalConfigOptions.AnalyzerOptions);

        public override AnalyzerConfigOptions GetOptions(SyntaxTree tree) => GetOptions(tree.FilePath);

        public override AnalyzerConfigOptions GetOptions(AdditionalText textFile) => GetOptions(textFile.Path);

        private ConfigOptions GetOptions(string path) => new(configurationSet.GetOptionsForSourcePath(path).AnalyzerOptions);
    }

    private sealed class ConfigOptions(ImmutableDictionary<string, string> values) : AnalyzerConfigOptions
    {
        public override IEnumerable<string> Keys => values.Keys;

        public override bool TryGetValue(string key, out string value) => values.TryGetValue(key, out value!);
    }
}
