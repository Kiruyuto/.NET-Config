using AsyncFixer.ImplicitTaskTypeMismatch;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.Text;

namespace Kiruyuto.DotNet.Config.Tests.AsyncFixer;

public class AsyncFixer06Tests
{
    private static readonly AnalyzerHost Host = new("AsyncFixer.globalconfig");

    [Test]
    public async Task AsyncFixer06_DiscardedTaskResult_ReportsWarning()
    {
        const string source = """
                              using System;
                              using System.Threading.Tasks;

                              internal class Example
                              {
                                  public Func<Task> CreateCallback()
                                  {
                                      return () => Task.FromResult(42);
                                  }
                              }
                              """;

        var diagnostics = await Host.AnalyzeAsync(source, new ImplicitTaskTypeMismatchAnalyzer());

        await Assert.That(diagnostics.Length).IsEqualTo(1);
        var diagnostic = diagnostics[0];
        await Assert.That(diagnostic.Id).IsEqualTo("AsyncFixer06");
        await Assert.That(diagnostic.Severity).IsEqualTo(DiagnosticSeverity.Warning);

        const string callback = "() => Task.FromResult(42)";
        var expectedSpan = new TextSpan(source.IndexOf(callback, StringComparison.Ordinal), callback.Length);
        await Assert.That(diagnostic.Location.SourceSpan).IsEqualTo(expectedSpan);
    }

    [Test]
    public async Task AsyncFixer06_PreservedTaskResult_ReportsNoWarning()
    {
        const string source = """
                              using System;
                              using System.Threading.Tasks;

                              internal class Example
                              {
                                  public Func<Task<int>> CreateCallback()
                                  {
                                      return () => Task.FromResult(42);
                                  }
                              }
                              """;

        var diagnostics = await Host.AnalyzeAsync(source, new ImplicitTaskTypeMismatchAnalyzer());

        await Assert.That(diagnostics).IsEmpty();
    }
}
