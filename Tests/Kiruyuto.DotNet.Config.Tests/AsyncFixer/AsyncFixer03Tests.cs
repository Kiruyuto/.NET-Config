using AsyncFixer.AsyncVoid;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.Text;

namespace Kiruyuto.DotNet.Config.Tests.AsyncFixer;

public class AsyncFixer03Tests
{
    private static readonly AnalyzerHost Host = new("AsyncFixer.globalconfig");

    [Test]
    public async Task AsyncFixer03_AsyncVoid_ReportsWarning()
    {
        const string source = """
                              using System.Threading.Tasks;

                              internal class Example
                              {
                                  public async void WorkAsync()
                                  {
                                      await Task.Yield();
                                  }
                              }
                              """;

        var diagnostics = await Host.AnalyzeAsync(source, new AsyncVoidAnalyzer());

        await Assert.That(diagnostics.Length).IsEqualTo(1);
        var diagnostic = diagnostics[0];
        await Assert.That(diagnostic.Id).IsEqualTo("AsyncFixer03");
        await Assert.That(diagnostic.Severity).IsEqualTo(DiagnosticSeverity.Warning);

        var expectedSpan = new TextSpan(source.IndexOf("void", StringComparison.Ordinal), "void".Length);
        await Assert.That(diagnostic.Location.SourceSpan).IsEqualTo(expectedSpan);
    }

    [Test]
    public async Task AsyncFixer03_AsyncTask_ReportsNoWarning()
    {
        const string source = """
                              using System.Threading.Tasks;

                              internal class Example
                              {
                                  public async Task WorkAsync()
                                  {
                                      await Task.Yield();
                                  }
                              }
                              """;

        var diagnostics = await Host.AnalyzeAsync(source, new AsyncVoidAnalyzer());

        await Assert.That(diagnostics).IsEmpty();
    }
}