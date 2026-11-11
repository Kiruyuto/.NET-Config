using Microsoft.CodeAnalysis;

namespace Kiruyuto.DotNet.Config.Tests.AsyncFixer;

public class AsyncFixerConfigurationTests
{
    [Test]
    public async Task AsyncFixerConfiguration_AllRules_UseWarningSeverity()
    {
        string[] expectedRuleIds =
        [
            "AsyncFixer01",
            "AsyncFixer02",
            "AsyncFixer03",
            "AsyncFixer04",
            "AsyncFixer05",
            "AsyncFixer06"
        ];

        var configuration = new AnalyzerHost("AsyncFixer.globalconfig").ConfigurationOptions;

        await Assert.That(configuration.Diagnostics).IsEmpty();
        await Assert.That(configuration.TreeOptions.Count).IsEqualTo(expectedRuleIds.Length);

        foreach (var ruleId in expectedRuleIds)
        {
            await Assert.That(configuration.TreeOptions.TryGetValue(ruleId, out var severity)).IsTrue();
            await Assert.That(severity).IsEqualTo(ReportDiagnostic.Warn);
        }
    }
}
