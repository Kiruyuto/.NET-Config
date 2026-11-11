using AsyncFixer.NestedTaskToOuterTask;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.Text;

namespace Kiruyuto.DotNet.Config.Tests.AsyncFixer;

public class AsyncFixer05Tests
{
    private static readonly AnalyzerHost Host = new("AsyncFixer.globalconfig");

    [Test]
    public async Task AsyncFixer05_NestedTask_ReportsWarning()
    {
        const string source = """
                              using System.Threading.Tasks;

                              internal class Example
                              {
                                  public async Task WorkAsync()
                                  {
                                      await Task.Factory.StartNew(() => Task.Delay(1));
                                  }
                              }
                              """;

        var diagnostics = await Host.AnalyzeAsync(source, new NestedTaskToOuterTaskAnalyzer());

        await Assert.That(diagnostics.Length).IsEqualTo(1);
        var diagnostic = diagnostics[0];
        await Assert.That(diagnostic.Id).IsEqualTo("AsyncFixer05");
        await Assert.That(diagnostic.Severity).IsEqualTo(DiagnosticSeverity.Warning);

        const string outerAwait = "await Task.Factory.StartNew(() => Task.Delay(1))";
        var expectedSpan = new TextSpan(source.IndexOf(outerAwait, StringComparison.Ordinal), outerAwait.Length);
        await Assert.That(diagnostic.Location.SourceSpan).IsEqualTo(expectedSpan);
    }

    [Test]
    public async Task AsyncFixer05_UnwrappedTask_ReportsNoWarning()
    {
        const string source = """
                              using System.Threading.Tasks;

                              internal class Example
                              {
                                  public async Task WorkAsync()
                                  {
                                      await Task.Run(() => Task.Delay(1));
                                  }
                              }
                              """;

        var diagnostics = await Host.AnalyzeAsync(source, new NestedTaskToOuterTaskAnalyzer());

        await Assert.That(diagnostics).IsEmpty();
    }
}