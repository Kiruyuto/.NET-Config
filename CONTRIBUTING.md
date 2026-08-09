# Contributing

> [!WARNING]
> The entry from the file with a higher value for global_level takes precedence. If `global_level` isn't explicitly defined and the file is named `.globalconfig`, the `global_level` value defaults to `100`; for all other global AnalyzerConfig files, `global_level` defaults to `0`. If the `global_level` values for the configuration files with conflicting entries are equal, a compiler warning is reported and both entries are ignored.  

> [!IMPORTANT]
> Every `.globalconfig` **needs** an `is_global = true` top level entry.  
> All config files in this repository should use the `.globalconfig` extension to ensure wildcard imports work as intended.

### Useful links
- [How is the rule order applied?](https://learn.microsoft.com/en-us/dotnet/fundamentals/code-analysis/configuration-files#precedence)
- [About .globalconfig files](https://learn.microsoft.com/en-us/dotnet/fundamentals/code-analysis/configuration-files#global-analyzerconfig)
- [Distributing as NuGet pkg](https://learn.microsoft.com/en-us/dotnet/fundamentals/code-analysis/configuration-files#distribution-in-nuget-packages)

## Modifying and adding new rule(s)
- If modifying existing rule(s):
  - Edit appropriate `.globalconfig` file in [`files/`](./Kiruyuto.DotNet.Config/files/) directory
- If adding new rule(s):
  - Append new rule(s) to appropriate existing `.globalconfig` file in [`files/`](./Kiruyuto.DotNet.Config/files/) directory
- If adding new analyzer dependency:
  - Add new package reference to [`Kiruyuto.DotNet.Config.csproj`](./Kiruyuto.DotNet.Config/Kiruyuto.DotNet.Config.csproj)
  - Create new appropriately named `.globalconfig` file in [`files/`](./Kiruyuto.DotNet.Config/files/) directory with `is_global = true` and rule configurations.   
  This file should be automatically picked up by wildcard import from [`Analyzers.props`](./Kiruyuto.DotNet.Config/build/Kiruyuto.DotNet.Config.Analyzers.props)  
  New file should follow the existing naming and descriptive convention to maintain consistency with other config files.

## Building & Local testing
Use a unique prerelease version for every local package so NuGet does not reuse a previous build from its global package cache. Run one of the following command blocks from the repository root.

### PowerShell
```powershell
$localPackageVersion = "0.0.1-local.$([DateTimeOffset]::UtcNow.ToUnixTimeMilliseconds())"
dotnet pack Kiruyuto.DotNet.Config/Kiruyuto.DotNet.Config.csproj -c Release -o ./local-packages "-p:PackageVersion=$localPackageVersion"
dotnet nuget add source (Resolve-Path ./local-packages).Path -n KiruyutoDotNetConfigLocal
```

### Bash
```bash
local_package_version="0.0.1-local.$(date +%s)"
dotnet pack Kiruyuto.DotNet.Config/Kiruyuto.DotNet.Config.csproj -c Release -o ./local-packages -p:PackageVersion="$local_package_version"
dotnet nuget add source "$(pwd)/local-packages" -n KiruyutoDotNetConfigLocal
```

Use the generated prerelease version when adding `Kiruyuto.DotNet.Config` to the project under test.

Then run this command to check if source was added:
```bash
dotnet nuget list source
```

When you are done testing and want to remove the local source, run:
```bash
dotnet nuget remove source KiruyutoDotNetConfigLocal
```

## Troubleshooting
- Running `dotnet msbuild -pp:preprocessed.xml` in the consuming project can help debug issues with the imported configs.  
  The generated `preprocessed.xml` file will contain the fully expanded MSBuild project file, including all imported `.props` files from the NuGet package.  
  This allows you to verify that the configurations from the package are being correctly imported and applied to your project.