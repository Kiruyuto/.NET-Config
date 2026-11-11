using AsyncFixer.UnnecessaryAsync;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace Kiruyuto.DotNet.Config.Tests.AsyncFixer;

public class AsyncFixer01Tests
{
    private static readonly AnalyzerHost Host = new("AsyncFixer.globalconfig");

    [Test]
    public async Task AsyncFixer01_UnnecessaryAsyncAwait_ReportsWarning()
    {
        const string source = """
                              using System.Threading.Tasks;

                              internal class Example
                              {
                                  public async Task<int> ReadAsync()
                                  {
                                      return await Task.FromResult(42);
                                  }
                              }
                              """;

        var diagnostics = await Host.AnalyzeAsync(source, new UnnecessaryAsyncAnalyzer());

        await Assert.That(diagnostics.Length).IsEqualTo(1);
        var diagnostic = diagnostics[0];
        await Assert.That(diagnostic.Id).IsEqualTo("AsyncFixer01");
        await Assert.That(diagnostic.Severity).IsEqualTo(DiagnosticSeverity.Warning);

        var method = (await diagnostic.Location.SourceTree!.GetRootAsync()).DescendantNodes().OfType<MethodDeclarationSyntax>().Single();
        await Assert.That(diagnostic.Location.SourceSpan).IsEqualTo(method.Span);
    }

    [Test]
    public async Task AsyncFixer01_ReturningTaskDirectly_ReportsNoWarning()
    {
        const string source = """
                              using System.Threading.Tasks;

                              internal class Example
                              {
                                  public Task<int> ReadAsync() => Task.FromResult(42);
                              }
                              """;

        var diagnostics = await Host.AnalyzeAsync(source, new UnnecessaryAsyncAnalyzer());

        await Assert.That(diagnostics).IsEmpty();
    }
}