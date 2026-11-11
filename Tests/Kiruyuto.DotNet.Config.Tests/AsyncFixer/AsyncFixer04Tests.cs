using AsyncFixer.AsyncCallInsideUsingBlock;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.Text;

namespace Kiruyuto.DotNet.Config.Tests.AsyncFixer;

/// <summary>
/// Unawaited async call in 'using' block
/// </summary>
public class AsyncFixer04Tests
{
    private static readonly AnalyzerHost Host = new("AsyncFixer.globalconfig");

    [Test]
    public async Task AsyncFixer04_UnawaitedCall_ReportsWarning()
    {
        const string source = """
                              using System.IO;

                              internal class Example
                              {
                                  public void Copy(Stream destination)
                                  {
                                      using (var source = new MemoryStream())
                                      {
                                          source.CopyToAsync(destination);
                                      }
                                  }
                              }
                              """;

        var diagnostics = await Host.AnalyzeAsync(source, new AsyncCallInsideUsingBlockAnalyzer());

        await Assert.That(diagnostics.Length).IsEqualTo(1);
        var diagnostic = diagnostics[0];
        await Assert.That(diagnostic.Id).IsEqualTo("AsyncFixer04");
        await Assert.That(diagnostic.Severity).IsEqualTo(DiagnosticSeverity.Warning);

        var expectedSpan = new TextSpan(source.IndexOf("source.CopyToAsync", StringComparison.Ordinal), "source".Length);
        await Assert.That(diagnostic.Location.SourceSpan).IsEqualTo(expectedSpan);
    }

    [Test]
    public async Task AsyncFixer04_AwaitedCall_ReportsNoWarning()
    {
        const string source = """
                              using System.IO;
                              using System.Threading.Tasks;

                              internal class Example
                              {
                                  public async Task CopyAsync(Stream destination)
                                  {
                                      using (var source = new MemoryStream())
                                      {
                                          await source.CopyToAsync(destination);
                                      }
                                  }
                              }
                              """;

        var diagnostics = await Host.AnalyzeAsync(source, new AsyncCallInsideUsingBlockAnalyzer());

        await Assert.That(diagnostics).IsEmpty();
    }
}
