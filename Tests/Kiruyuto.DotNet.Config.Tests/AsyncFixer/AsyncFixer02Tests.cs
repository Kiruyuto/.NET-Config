using AsyncFixer.BlockingCallInsideAsync;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.Text;

namespace Kiruyuto.DotNet.Config.Tests.AsyncFixer;

public class AsyncFixer02Tests
{
    private static readonly AnalyzerHost Host = new("AsyncFixer.globalconfig");

    [Test]
    public async Task AsyncFixer02_ThreadSleep_ReportsWarning()
    {
        const string source = """
                              using System.Threading;
                              using System.Threading.Tasks;

                              internal class Example
                              {
                                  public async Task WorkAsync()
                                  {
                                      Thread.Sleep(1000);
                                      await Task.Yield();
                                  }
                              }
                              """;

        var diagnostics = await Host.AnalyzeAsync(source, new BlockingCallInsideAsyncAnalyzer());

        await Assert.That(diagnostics.Length).IsEqualTo(1);
        var diagnostic = diagnostics[0];
        await Assert.That(diagnostic.Id).IsEqualTo("AsyncFixer02");
        await Assert.That(diagnostic.Severity).IsEqualTo(DiagnosticSeverity.Warning);

        const string blockingCall = "Thread.Sleep(1000)";
        var expectedSpan = new TextSpan(source.IndexOf(blockingCall, StringComparison.Ordinal), blockingCall.Length);
        await Assert.That(diagnostic.Location.SourceSpan).IsEqualTo(expectedSpan);
    }

    [Test]
    public async Task AsyncFixer02_TaskDelay_ReportsNoWarning()
    {
        const string source = """
                              using System.Threading.Tasks;

                              internal class Example
                              {
                                  public async Task WorkAsync()
                                  {
                                      await Task.Delay(1000);
                                      await Task.Yield();
                                  }
                              }
                              """;

        var diagnostics = await Host.AnalyzeAsync(source, new BlockingCallInsideAsyncAnalyzer());

        await Assert.That(diagnostics).IsEmpty();
    }
}
