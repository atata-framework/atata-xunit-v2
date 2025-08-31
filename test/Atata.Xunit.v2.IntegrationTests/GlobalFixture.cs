[assembly: TestFramework(AssemblyFixtureFramework.TypeName, AssemblyFixtureFramework.AssemblyName)]

namespace Atata.Xunit.IntegrationTests;

public sealed class GlobalFixture : AtataGlobalFixture
{
    protected override void ConfigureAtataContextBaseConfiguration(AtataContextBuilder builder) =>
        builder.LogConsumers.AddNLogFile();
}
