<p align="center">
  <img src="https://raw.githubusercontent.com/Kiruyuto/.NET-Config/master/.github/resources/readme-banner.png" alt="README banner">
</p>

<p align="center">
  Personal set of rules, analyzers, and build defaults distributed as a NuGet package for .NET 10 C# projects.
</p>

<p align="center">
  <sub>
    <strong>Heavily</strong> based on
    <a href="https://github.com/meziantou/">Gérald Barré (@Meziantou)</a>'s
    "<a href="https://www.meziantou.net/sharing-coding-style-and-roslyn-analyzers-across-projects.htm">Sharing coding style and Roslyn analyzers across projects</a>"
    post and his
    <a href="https://github.com/meziantou/Meziantou.DotNet.CodingStandard">CodingStandard</a>
    repository.<br>
    This config contains rules changed and fine-tuned to my personal and work needs as well as preferences.
  </sub>
</p>

## Usage
Add the [NuGet package](https://www.nuget.org/packages/Kiruyuto.DotNet.Config/#versions-body-tab) package to your project, and the configs will be automatically imported.  
`PrivateAssets="all"` prevents the configuration package and its analyzer dependencies from becoming dependencies of a package you publish.

### Direct package reference
```xml
<ItemGroup>
  <PackageReference Include="Kiruyuto.DotNet.Config" Version="2.4.14" PrivateAssets="all" />
</ItemGroup>
```

### Central package management
```xml
<!-- Directory.Packages.props -->
<Project>
  <PropertyGroup>
    <ManagePackageVersionsCentrally>true</ManagePackageVersionsCentrally>
  </PropertyGroup>

  <ItemGroup>
    <PackageVersion Include="Kiruyuto.DotNet.Config" Version="2.4.14" />
  </ItemGroup>
</Project>
```

```xml
<!-- Directory.Build.props -->
<Project>
  <ItemGroup>
    <PackageReference Include="Kiruyuto.DotNet.Config" PrivateAssets="all" />
  </ItemGroup>
</Project>
```

## Applied defaults
The package imports the following policy into consuming projects:

| Area | Defaults |
| --- | --- |
| C# projects | Enables nullable reference types, implicit usings, unsafe code, deterministic builds, and XML documentation. Adds global usings for `System.Diagnostics.CodeAnalysis` and `System.Text`, and disables `CS1591`. |
| Analysis | Enables .NET analyzers and build-time code-style analysis using `AnalysisLevel=10-all`, strict compiler features, the packaged rule configurations, banned APIs, and analyzer timing reports. |
| Release and CI | Release builds enable optimization and treat MSBuild warnings as errors. CI builds also set `ContinuousIntegrationBuild` and treat compiler and analyzer warnings as errors. |
| Package authoring | Unless overridden, `RepositoryType=git`, `EmbedUntrackedSources=true`, and `DebugType=embedded` are applied to consumer projects. Embedded PDBs travel inside assemblies; no separate `.snupkg` is generated. |

This is intentionally strict: warnings can fail Release and CI builds. `10-all` pins the built-in analyzer profile to .NET 10.

### Overriding defaults
NuGet package build props are imported before the body of a consuming project file. Defaults whose values are conditional on being empty can be preselected in `Directory.Build.props`. Any setting can be overridden later in the project file or in `Directory.Build.targets`; use `Directory.Build.targets` for repository-wide overrides that must win over this package's unconditional assignments.

Diagnostic severities and analyzer options can be customized in a project-owned `.editorconfig` or `.globalconfig`. Individual compiler or analyzer diagnostics can also be suppressed with the standard MSBuild warning properties.

> [!NOTE]
> NuGet excludes package build imports while generating the restore graph, so this package intentionally does not distribute NuGet audit policy. This repository configures audit in its root [Directory.Build.props](https://github.com/Kiruyuto/.NET-Config/blob/master/Directory.Build.props); consuming repositories should configure their own policy there or in another repository-owned MSBuild file evaluated during restore.

> [!WARNING]
> This package bans EF Core's `AddAsync` and `AddRangeAsync` by default.  
> Projects that intentionally rely on async value generators, such as `HiLo`, can disable only those two bans using:
> ```xml
> <Project>
>   <PropertyGroup>
>     <KiruyutoDotNetConfigEnableEntityFrameworkCoreAsyncAddBans>false</KiruyutoDotNetConfigEnableEntityFrameworkCoreAsyncAddBans>
>   </PropertyGroup>
> </Project>
> ```
>
> The toggle also controls the corresponding VSTHRD103 exclusions. Setting it to `false` removes the async-add bans and stops excluding synchronous `Add`/`AddRange`, so VSTHRD103 may recommend their async counterparts in async methods.

## Structure overview
- Dependencies can be found in [Kiruyuto.DotNet.Config.csproj](https://github.com/Kiruyuto/.NET-Config/blob/master/Kiruyuto.DotNet.Config/Kiruyuto.DotNet.Config.csproj)
- `.globalconfig` rule configurations are located in the [`files/` directory](https://github.com/Kiruyuto/.NET-Config/tree/master/Kiruyuto.DotNet.Config/files)
- `.props` and `.targets` files are located in the [`build/` directory](https://github.com/Kiruyuto/.NET-Config/tree/master/Kiruyuto.DotNet.Config/build). These are split into categories for improved maintainability

## Contributing
See [CONTRIBUTING.md](https://github.com/Kiruyuto/.NET-Config/blob/master/CONTRIBUTING.md) for guidelines, rule authoring, and local build/testing instructions.