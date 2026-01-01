# .NET-Config
Personal set of rules and analyzers distributed as a NuGet package to share configuration across .NET projects.

**Heavily** based on [Gérald Barré (@Meziantou)](https://github.com/meziantou)'s "*Sharing coding style and Roslyn analyzers across projects*" [post](https://www.meziantou.net/sharing-coding-style-and-roslyn-analyzers-across-projects.htm) and his [CodingStandard](https://github.com/meziantou/Meziantou.DotNet.CodingStandard) repository.  
This config contains rules changed and fine-tuned to my personal and work needs as well as preferences.

### Usage
Add the [nuget](https://www.nuget.org/packages/Kiruyuto.DotNet.Config/#versions-body-tab) package to your project, and the configs will be automatically imported.

> [!WARNING]
> This package does not support transitive behavior. You need to add it to each project where you want to apply the configuration.

> [!IMPORTANT]
> It is recommended to use `Directory.Build.props` in your project over per `.csproj` configuration

### Structure overview
- Dependencies can be found in [.nuspec file](./Kiruyuto.DotNet.Config.nuspec)
- Configs are located in [`src/files/` directory](./src/files/)
- `.props` files with their configs are located in [`src/build/` directory](./src/build/). These are split into categories for improved maintainability 

### Contributing
Useful links are located in [CONTRIBUTING.md](CONTRIBUTING.md) as well as some of the most important `TL;DRs`