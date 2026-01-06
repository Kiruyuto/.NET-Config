> [!WARNING]
> The entry from the file with a higher value for global_level takes precedence. If `global_level` isn't explicitly defined and the file is named `.globalconfig`, the `global_level` value defaults to `100`; for all other global AnalyzerConfig files, `global_level` defaults to `0`. If the `global_level` values for the configuration files with conflicting entries are equal, a compiler warning is reported and both entries are ignored.  

> [!IMPORTANT]
> Every `.globalconfig` **needs** an `is_global = true` top level entry.  
> All config files in this repository should be `.globalconfigs` to ensure wildcard imports work as intended.

### Useful links
- [How is the rule order applied?](https://learn.microsoft.com/en-us/dotnet/fundamentals/code-analysis/configuration-files#precedence)
- [About .globalconfigs](https://learn.microsoft.com/en-us/dotnet/fundamentals/code-analysis/configuration-files#global-analyzerconfig)
- [Distributing as NuGet pkg](https://learn.microsoft.com/en-us/dotnet/fundamentals/code-analysis/configuration-files#distribution-in-nuget-packages)

### Modifying and adding new rule(s)
- If modifying existing rule(s):
  - Edit appropriate `.globalconfig` file in `[files/](./Kiruyuto.DotNet.Config/files/)` directory
- If adding new rule(s):
  - Append new rule(s) to appropriate existing `.globalconfig` file in `[files/](./Kiruyuto.DotNet.Config/files/)` directory
- If adding new analyzer dependency:
  - Add new package reference to `[Kiruyuto.DotNet.Config.csproj](./Kiruyuto.DotNet.Config/Kiruyuto.DotNet.Config.csproj)`
  - Create new appropriately named `.globalconfig` file in `[files/](./Kiruyuto.DotNet.Config/files/)` directory with `is_global = true` and rule configurations.   
  This file should be atuomatically picked up by wildcard import from `[Analyzers.props](./Kiruyuto.DotNet.Config/build/Kiruyuto.DotNet.Config.Analyzers.props`  
  New file should follow the existing naming and descriptive convention to maintain consistency with other config files.