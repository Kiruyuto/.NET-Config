# Changelog

## [2.3.5](https://github.com/Kiruyuto/.NET-Config/compare/config-2.3.4...config-2.3.5) (2026-01-12)


### Chores

* Remove default SourceLink dependency ([c0837e4](https://github.com/Kiruyuto/.NET-Config/commit/c0837e40a08c382592df1493b8c5db1b98b1c99c))

## [2.3.4](https://github.com/Kiruyuto/.NET-Config/compare/config-2.3.3...config-2.3.4) (2026-01-08)


### Chores

* **dependencies:** Update dependency SonarAnalyzer.CSharp to 10.18.0.131500 (dotnet) ([#80](https://github.com/Kiruyuto/.NET-Config/issues/80)) ([2db28ce](https://github.com/Kiruyuto/.NET-Config/commit/2db28cee083f2c2ff3fc84824b89ca7c6b638f4e))

## [2.3.3](https://github.com/Kiruyuto/.NET-Config/compare/config-2.3.2...config-2.3.3) (2026-01-06)


### Chores

* Add CA1873 max_log_level setting ([7b8b3fa](https://github.com/Kiruyuto/.NET-Config/commit/7b8b3fac0b2b5e5fc5c37490ae4ce297aa8a3c94))
* Adjust AsyncFixer severity to warning ([2581ab6](https://github.com/Kiruyuto/.NET-Config/commit/2581ab6124af80a7e1025a6ac1b93fe497393d51))
* Adjust CA1068 severity to warning ([2581ab6](https://github.com/Kiruyuto/.NET-Config/commit/2581ab6124af80a7e1025a6ac1b93fe497393d51))
* Adjust CA1069 severity to warning ([2581ab6](https://github.com/Kiruyuto/.NET-Config/commit/2581ab6124af80a7e1025a6ac1b93fe497393d51))
* Adjust CA1509 severity to warning ([2581ab6](https://github.com/Kiruyuto/.NET-Config/commit/2581ab6124af80a7e1025a6ac1b93fe497393d51))
* Adjust CA2254 severity to warning ([2581ab6](https://github.com/Kiruyuto/.NET-Config/commit/2581ab6124af80a7e1025a6ac1b93fe497393d51))


### Documentation improvements

* Add note on CA1873 rule ([7b8b3fa](https://github.com/Kiruyuto/.NET-Config/commit/7b8b3fac0b2b5e5fc5c37490ae4ce297aa8a3c94))
* Add note on NuGet auditing in NugetAudit.props ([e368ec9](https://github.com/Kiruyuto/.NET-Config/commit/e368ec9fb57b27c843f07b411c50809a6db09b11))
* Refine comment in Analyzers.props ([e368ec9](https://github.com/Kiruyuto/.NET-Config/commit/e368ec9fb57b27c843f07b411c50809a6db09b11))
* Remove redundant comment in NugetAuthoring.props ([e368ec9](https://github.com/Kiruyuto/.NET-Config/commit/e368ec9fb57b27c843f07b411c50809a6db09b11))
* Update comment for CI detection in CI.props ([e368ec9](https://github.com/Kiruyuto/.NET-Config/commit/e368ec9fb57b27c843f07b411c50809a6db09b11))

## [2.3.2](https://github.com/Kiruyuto/.NET-Config/compare/config-2.3.1...config-2.3.2) (2026-01-06)


### Chores

* Adjust CA2201 severity to none ([71b5651](https://github.com/Kiruyuto/.NET-Config/commit/71b56514d8d10b3480608e02005bc92d080ef341))
* Remove attribute naming rule from code style configuration ([12c0235](https://github.com/Kiruyuto/.NET-Config/commit/12c0235d47d25e09c3369ded577a4a25b6d0af05))


### Documentation improvements

* Update README.md with building and local testing instructions ([5d38ab2](https://github.com/Kiruyuto/.NET-Config/commit/5d38ab2bbfdce7396768b29a5fc6322c983eb6d0))

## [2.3.1](https://github.com/Kiruyuto/.NET-Config/compare/config-2.3.0...config-2.3.1) (2026-01-06)


### Bug Fixes

* Invalid build package path ([f937881](https://github.com/Kiruyuto/.NET-Config/commit/f93788156769238788703afea28d2283811c17a5))
* Remove `SonarAnalyzer` config from CodeQuality config ([77146f4](https://github.com/Kiruyuto/.NET-Config/commit/77146f48f05a2a2edc70cca805661522c7168110))


### Chores

* Rename CodeQuality config ([0c4831a](https://github.com/Kiruyuto/.NET-Config/commit/0c4831a7bd599366eb976506196e0a59594beeb5))


### Documentation improvements

* Update CONTRIBUTING.md with troubleshooting guidance for configs ([38b324c](https://github.com/Kiruyuto/.NET-Config/commit/38b324c969d47b94ff5c07845063903ef6948fc1))

## [2.3.0](https://github.com/Kiruyuto/.NET-Config/compare/config-2.2.1...config-2.3.0) (2026-01-06)


### Features & Enhancements

* Migrate from `.nuspec` to `.csproj`-based packaging ([#76](https://github.com/Kiruyuto/.NET-Config/issues/76)) ([af60b2d](https://github.com/Kiruyuto/.NET-Config/commit/af60b2d82cf5c34ea81c9d67e4de6a6f10ff405f))


### Chores

* Adjust global_level to 100 for AsyncFixer config ([e8248f3](https://github.com/Kiruyuto/.NET-Config/commit/e8248f3012716c5c4d84b557facfcd1f979e231e))


### Documentation improvements

* Adjust SonarAnalyzer-specific code analysis rules ([e9b9c1b](https://github.com/Kiruyuto/.NET-Config/commit/e9b9c1b17302d2389a73c9e607cad1b0d10174a6))
* Fix trailing comments ([df20076](https://github.com/Kiruyuto/.NET-Config/commit/df200760361b6daa33be2718db724c025117aefa))

## [2.2.1](https://github.com/Kiruyuto/.NET-Config/compare/config-2.2.0...config-2.2.1) (2026-01-04)


### Chores

* Adjust naming rules to better respect MS guidelines ([5fd3779](https://github.com/Kiruyuto/.NET-Config/commit/5fd377917cda9151edc20dd0a4e7fa0d8b8b017f))


### Documentation improvements

* Add SonarAnalyzer-specific code analysis rules ([2e28c86](https://github.com/Kiruyuto/.NET-Config/commit/2e28c8696a7c4b5e53d6eba41d757b4a82bed54d))

## [2.2.0](https://github.com/Kiruyuto/.NET-Config/compare/config-2.1.7...config-2.2.0) (2026-01-04)


### Features & Enhancements

* Add AsyncFixer dependency and configuration file ([fd3f5d0](https://github.com/Kiruyuto/.NET-Config/commit/fd3f5d067f165120562ae5f228102cfc473404a2))


### Bug Fixes

* Rename SonarLint-specific file to respect usage of standalone nuget package ([60bb27f](https://github.com/Kiruyuto/.NET-Config/commit/60bb27f35b64dc1a8be854c6641772b67a417773))


### Chores

* Adjust `global_level` to 100 for SonarLint configuration; Remove unnecessary comments; Fix scripts path ([6a8894f](https://github.com/Kiruyuto/.NET-Config/commit/6a8894f61af7eb434f4c06e1c3bf58dc8a2d9eb3))

## [2.1.7](https://github.com/Kiruyuto/.NET-Config/compare/config-2.1.6...config-2.1.7) (2026-01-04)


### Chores

* Explicitly disable CS1591 rule in `.props` file ([537c594](https://github.com/Kiruyuto/.NET-Config/commit/537c594e887c8607baf9e9c5b9a957eff97b97f3))


### Documentation improvements

* Improve 'structure overview' header wording ([9729441](https://github.com/Kiruyuto/.NET-Config/commit/972944117fb32a03f3cdced4ef1ee5466c0ce94b))
* Update note for global_level in configuration files ([4b9c05d](https://github.com/Kiruyuto/.NET-Config/commit/4b9c05d0005fd2786acf404cf6b581dba8d57ee5))

## [2.1.6](https://github.com/Kiruyuto/.NET-Config/compare/config-2.1.5...config-2.1.6) (2026-01-01)


### Refactors

* Split props into modular configuration files; Improve docs ([#70](https://github.com/Kiruyuto/.NET-Config/issues/70)) ([869dba2](https://github.com/Kiruyuto/.NET-Config/commit/869dba26b00f0f5be5c74b2507662d6960ae09fb))

## [2.1.5](https://github.com/Kiruyuto/.NET-Config/compare/config-2.1.4...config-2.1.5) (2026-01-01)


### Chores

* Add VSCode settings for globalconfig file association ([b51e7cc](https://github.com/Kiruyuto/.NET-Config/commit/b51e7cc6e02c1d4317c3bbdbb9930ac6ea0df716))
* Adjust CA1032 severity to 'none' ([38037cc](https://github.com/Kiruyuto/.NET-Config/commit/38037cc952ff5517dbfc8bc3998f1118de669167))
* Adjust CA1708 severity to 'none' ([dbffeae](https://github.com/Kiruyuto/.NET-Config/commit/dbffeae6b56ec2fe675dc56c7646d0860c8f27a0))
* Adjust CA1812 severity to 'none' ([9f888c9](https://github.com/Kiruyuto/.NET-Config/commit/9f888c91dfb57976e334f5fb2bb599fac7348ad9))
* Adjust IDE0058 severity to 'none'' ([c068dff](https://github.com/Kiruyuto/.NET-Config/commit/c068dff495d0164b4f7c205174385d42905e569a))
* Change severity levels from error to warning for various IDE rules ([1e18221](https://github.com/Kiruyuto/.NET-Config/commit/1e18221d7b80fe5a1114d803fd10e18243113648))
* Improve commit message instructions ([42c26fd](https://github.com/Kiruyuto/.NET-Config/commit/42c26fded9334d61527d748f621d7a3bc75f0369))


### Documentation improvements

* Add note on disabling S125 rule ([e40f410](https://github.com/Kiruyuto/.NET-Config/commit/e40f41017cb84f7c2b324b38c08537bc4c7a0039))
* Improve notes for CA1028 and IDE0058 severity changes ([d87a331](https://github.com/Kiruyuto/.NET-Config/commit/d87a331e322f47bfe364358472e1c06e971a0592))

## [2.1.4](https://github.com/Kiruyuto/.NET-Config/compare/config-2.1.3...config-2.1.4) (2025-12-31)


### 🐛 Bug Fixes

* Update configuration files to resolve Rider-related issues and clean up obsolete entries ([89b98e5](https://github.com/Kiruyuto/.NET-Config/commit/89b98e52437e4b62350038451167c9d1ebf8da17))

## [2.1.3](https://github.com/Kiruyuto/.NET-Config/compare/config-2.1.2...config-2.1.3) (2025-12-31)


### 🐛 Bug Fixes

* Refactor editor and global config file handling; remove obsolete targets ([28a9a33](https://github.com/Kiruyuto/.NET-Config/commit/28a9a33cc7f3c1e221cc005d390b847b8fb9913d))

## [2.1.2](https://github.com/Kiruyuto/.NET-Config/compare/config-2.1.1...config-2.1.2) (2025-12-31)


### 🐛 Bug Fixes

* Use correct operation syntax ([25ed014](https://github.com/Kiruyuto/.NET-Config/commit/25ed0146370dd2efd7f62821e0b034ed689400d2))

## [2.1.1](https://github.com/Kiruyuto/.NET-Config/compare/config-2.1.0...config-2.1.1) (2025-12-31)


### 🐛 Bug Fixes

* Attempt to resoolve Rider related issue by copying files before build ([7de64de](https://github.com/Kiruyuto/.NET-Config/commit/7de64de4ffd2a6d1179e9334837a1c777dbe2bbb))

## [2.1.0](https://github.com/Kiruyuto/.NET-Config/compare/config-2.0.0...config-2.1.0) (2025-12-31)


### 🚀 Features & Enhancements

* Update license handling and improve globalconfig clarity ([1bd7f57](https://github.com/Kiruyuto/.NET-Config/commit/1bd7f571d45537e51b27e04593aaa4da65a39427))


### 🐛 Bug Fixes

* Correct README.md file target path in nuspec ([a075399](https://github.com/Kiruyuto/.NET-Config/commit/a075399aa4481e9ab3082eb71d46e142d1f03991))
* Update README.md path in nuspec to correct location ([f14cbc9](https://github.com/Kiruyuto/.NET-Config/commit/f14cbc9ed91d656f47195772885e4925fc290841))

## [2.0.0](https://github.com/Kiruyuto/.NET-Config/compare/config-1.3.18...config-2.0.0) (2025-12-31)


### ⚠ BREAKING CHANGES

* Adjust some rules; Extend `BannedSymbols`; Improve maintainability ([#60](https://github.com/Kiruyuto/.NET-Config/issues/60))

### 💅 Refactors

* Adjust some rules; Extend `BannedSymbols`; Improve maintainability ([#60](https://github.com/Kiruyuto/.NET-Config/issues/60)) ([8f1308c](https://github.com/Kiruyuto/.NET-Config/commit/8f1308cbb0805bd59e693b1e9a6794f9ec092eb2))

## [1.3.18](https://github.com/Kiruyuto/.NET-Config/compare/config-1.3.17...config-1.3.18) (2025-12-17)


### 🏡 Chore

* **dependencies:** Update dependency SonarAnalyzer.CSharp to 10.17.0.131074 (dotnet) ([#58](https://github.com/Kiruyuto/.NET-Config/issues/58)) ([674912c](https://github.com/Kiruyuto/.NET-Config/commit/674912cc4bdd2c32ac38648d42875d06cc548739))

## [1.3.17](https://github.com/Kiruyuto/.NET-Config/compare/config-1.3.16...config-1.3.17) (2025-12-10)


### 🏡 Chore

* **dependencies:** Update dependency Microsoft.EntityFrameworkCore.Analyzers to 10.0.1 (dotnet) ([#55](https://github.com/Kiruyuto/.NET-Config/issues/55)) ([910cd68](https://github.com/Kiruyuto/.NET-Config/commit/910cd683def46c19e8f65f5bfd55c9b3bdbc1645))

## [1.3.16](https://github.com/Kiruyuto/.NET-Config/compare/config-1.3.15...config-1.3.16) (2025-12-03)


### 🏡 Chore

* **dependencies:** Update dependency SonarAnalyzer.CSharp to 10.16.1.129956 (dotnet) ([#52](https://github.com/Kiruyuto/.NET-Config/issues/52)) ([54edf8f](https://github.com/Kiruyuto/.NET-Config/commit/54edf8f43ca3199fbe936ab15b672691867d1f5c))

## [1.3.15](https://github.com/Kiruyuto/.NET-Config/compare/config-1.3.14...config-1.3.15) (2025-11-26)


### 🏡 Chore

* **dependencies:** Update .NET to 10.16.0.128591 (dotnet) ([#48](https://github.com/Kiruyuto/.NET-Config/issues/48)) ([7d2f3b8](https://github.com/Kiruyuto/.NET-Config/commit/7d2f3b89577e9239951bd079c0e1f6406f7d440b))

## [1.3.14](https://github.com/Kiruyuto/.NET-Config/compare/config-1.3.13...config-1.3.14) (2025-11-14)


### 🏡 Chore

* **dependencies:** Update .NET Major dependencies to v10 (dotnet) (major) ([#44](https://github.com/Kiruyuto/.NET-Config/issues/44)) ([c7f5aa9](https://github.com/Kiruyuto/.NET-Config/commit/c7f5aa94834199d78845b8ef1cf347732c1f6745))

## [1.3.13](https://github.com/Kiruyuto/.NET-Config/compare/config-1.3.12...config-1.3.13) (2025-10-15)


### 🐛 Bug Fixes

* Simplify conditions for CodeAnalysisTreatWarningsAsErrors and EnforceCodeStyleInBuild ([fcd94de](https://github.com/Kiruyuto/.NET-Config/commit/fcd94de901587a58395600ddd9310b9888e60af5))

## [1.3.12](https://github.com/Kiruyuto/.NET-Config/compare/config-1.3.11...config-1.3.12) (2025-10-15)


### 🏡 Chore

* **dependencies:** Update dependency Microsoft.EntityFrameworkCore.Analyzers to 9.0.10 (.NET) ([#40](https://github.com/Kiruyuto/.NET-Config/issues/40)) ([50d0d11](https://github.com/Kiruyuto/.NET-Config/commit/50d0d11cd7d7457075910ab6c227a2a922a66953))
* Update code style preferences in editorconfig files ([36a38d3](https://github.com/Kiruyuto/.NET-Config/commit/36a38d3dbb5b89201034976f6c5bae8521531d36))

## [1.3.11](https://github.com/Kiruyuto/.NET-Config/compare/config-1.3.10...config-1.3.11) (2025-10-03)


### 🏡 Chore

* Enhance CI message to include project name ([6a841fb](https://github.com/Kiruyuto/.NET-Config/commit/6a841fbbd0255317d2b574a9606f9baff0647e12))
* Update .gitignore to include various file types and directories for .NET and JS projects ([aff5a53](https://github.com/Kiruyuto/.NET-Config/commit/aff5a534c17421770980f99d4fcd1cda6543fd6a))

## [1.3.10](https://github.com/Kiruyuto/.NET-Config/compare/config-1.3.9...config-1.3.10) (2025-10-02)


### 🏡 Chore

* Update severity level for CA1002 to none ([7af1739](https://github.com/Kiruyuto/.NET-Config/commit/7af173993666726db25ea6b5feb58f07f270069d))

## [1.3.9](https://github.com/Kiruyuto/.NET-Config/compare/config-1.3.8...config-1.3.9) (2025-10-01)


### 🏡 Chore

* Update severity levels for IDE0058 (disable) ([5184278](https://github.com/Kiruyuto/.NET-Config/commit/51842788a0dd77cb003c67e413115af348da8bbd))

## [1.3.8](https://github.com/Kiruyuto/.NET-Config/compare/config-1.3.7...config-1.3.8) (2025-09-27)


### 🏡 Chore

* Optimize Release builds and Enable 'GenerateDocumentationFile' ([a47c9c9](https://github.com/Kiruyuto/.NET-Config/commit/a47c9c9a214fb766f6070a4e690b49e7126e2add))

## [1.3.7](https://github.com/Kiruyuto/.NET-Config/compare/config-1.3.6...config-1.3.7) (2025-09-27)


### 🏡 Chore

* Add conditional CodeAnalysisTreatWarningsAsErrors ([e998b3f](https://github.com/Kiruyuto/.NET-Config/commit/e998b3fe4c719e35a8597d690cecc1ea6a29acb5))
* Add ContinuousIntegrationBuild property for GitHub Actions ([31f15ed](https://github.com/Kiruyuto/.NET-Config/commit/31f15edf358edffaff6a5eab98ef0b6ffec7e5f7))
* Add target to print ContinuousIntegrationBuild message in GitHub Actions ([1fd0d05](https://github.com/Kiruyuto/.NET-Config/commit/1fd0d050130309c435fb509706de6287305b1dff))

## [1.3.6](https://github.com/Kiruyuto/.NET-Config/compare/config-1.3.5...config-1.3.6) (2025-09-24)


### 🏡 Chore

* Disable problematic line break and wrapping options until resolved ([f4c8245](https://github.com/Kiruyuto/.NET-Config/commit/f4c8245b9853c58aaf930d2e9fbf3cbf19cf7cd0))

## [1.3.5](https://github.com/Kiruyuto/.NET-Config/compare/config-1.3.4...config-1.3.5) (2025-09-10)


### 🏡 Chore

* **dependencies:** Update dependency Microsoft.EntityFrameworkCore.Analyzers to 9.0.9 ([#27](https://github.com/Kiruyuto/.NET-Config/issues/27)) ([4be3dd7](https://github.com/Kiruyuto/.NET-Config/commit/4be3dd725f870b08ba4cc8e15f687fd2352d241a))

## [1.3.4](https://github.com/Kiruyuto/.NET-Config/compare/config-1.3.3...config-1.3.4) (2025-08-29)


### 🐛 Bug Fixes

* Use valid rule option ([908f4d9](https://github.com/Kiruyuto/.NET-Config/commit/908f4d9dd5fbe33710c9806cf1cd444534e1cfab))


### 🏡 Chore

* Provide resharper override for `object_initializers` option issues ([ac7f4bd](https://github.com/Kiruyuto/.NET-Config/commit/ac7f4bd55d87483cc4affb50ad27ecea1e704616))
* Reenable forcing wrapping options and add issue note ([ac7f4bd](https://github.com/Kiruyuto/.NET-Config/commit/ac7f4bd55d87483cc4affb50ad27ecea1e704616))

## [1.3.3](https://github.com/Kiruyuto/.NET-Config/compare/config-1.3.2...config-1.3.3) (2025-08-29)


### 🏡 Chore

* Disable forcing wrapping options ([a3f1622](https://github.com/Kiruyuto/.NET-Config/commit/a3f16225c9a2b3b1ec1ec777d321cba707fae081))

## [1.3.2](https://github.com/Kiruyuto/.NET-Config/compare/config-1.3.1...config-1.3.2) (2025-08-26)


### 🏡 Chore

* Reduce max line length ([5f2b868](https://github.com/Kiruyuto/.NET-Config/commit/5f2b868f8715a23ef5b88fd2ade1610fbd42d982))

## [1.3.1](https://github.com/Kiruyuto/.NET-Config/compare/config-1.3.0...config-1.3.1) (2025-08-23)


### 🏡 Chore

* Disable `CA1032` rule ([339ba41](https://github.com/Kiruyuto/.NET-Config/commit/339ba4116fc538bbd96406b2a78f411b9054b225))

## [1.3.0](https://github.com/Kiruyuto/.NET-Config/compare/config-1.2.2...config-1.3.0) (2025-08-17)


### 🚀 Features & Enhancements

* Add license ([ed517bf](https://github.com/Kiruyuto/.NET-Config/commit/ed517bf0fead150e24b0a7b5a65a6ea8b0edb4d6))


### 🏡 Chore

* Keep `CA1034` disabled by default to avoid multiple problem while working with external APIs ([21f3900](https://github.com/Kiruyuto/.NET-Config/commit/21f39007c926fd5132fce64cc8ef061143480a1a))

## [1.2.2](https://github.com/Kiruyuto/.NET-Config/compare/config-1.2.1...config-1.2.2) (2025-08-17)


### 🐛 Bug Fixes

* Remove glob pattern from global editorconfig ([bb53ac1](https://github.com/Kiruyuto/.NET-Config/commit/bb53ac18875766f129f5409fd46ca575ce10c255))


### 🏡 Chore

* Disable `CS8669` generating false-positives ([7f5520b](https://github.com/Kiruyuto/.NET-Config/commit/7f5520b788003faf77edad782731328ff617b35a))

## [1.2.1](https://github.com/Kiruyuto/.NET-Config/compare/config-1.2.0...config-1.2.1) (2025-08-17)


### 🐛 Bug Fixes

* Remove global editorconfig reference ([94bbea9](https://github.com/Kiruyuto/.NET-Config/commit/94bbea9b6b7b99e9e456c22d189103607e9bb28b))

## [1.2.0](https://github.com/Kiruyuto/.NET-Config/compare/config-1.1.3...config-1.2.0) (2025-08-17)


### 🚀 Features & Enhancements

* Add `EntityFrameworkCore` analyzers ([b6ef708](https://github.com/Kiruyuto/.NET-Config/commit/b6ef7087cb601d2fb3e9b2316a007777d4f561cf))

## [1.1.3](https://github.com/Kiruyuto/.NET-Config/compare/config-1.1.2...config-1.1.3) (2025-08-16)


### 🏡 Chore

* Revert single-line-statements back to default value ([dea079f](https://github.com/Kiruyuto/.NET-Config/commit/dea079f0edcc32507a7b8f52c9809489764b83b1))


### 📑 Documentation

* Fix typo in docs ([5bab814](https://github.com/Kiruyuto/.NET-Config/commit/5bab814de9244f642b551f619360e86c661b0520))

## [1.1.2](https://github.com/Kiruyuto/.NET-Config/compare/config-1.1.1...config-1.1.2) (2025-08-16)


### 🏡 Chore

* Add .gitignore ([9b00efa](https://github.com/Kiruyuto/.NET-Config/commit/9b00efafa829246b48499d00c4300fef9e519f3b))
* Rename package ([5537268](https://github.com/Kiruyuto/.NET-Config/commit/5537268b6c4b69ec4537384d6eeab4065b278815))


### 🎨 Style

* Adjust readme ([211bea5](https://github.com/Kiruyuto/.NET-Config/commit/211bea5dd02ee190678d2f262b5a576561d94ad6))

## [1.1.1](https://github.com/Kiruyuto/.NET-Config/compare/config-1.1.0...config-1.1.1) (2025-08-16)


### 📑 Documentation

* Improve docs for IDE0010 ([42fc628](https://github.com/Kiruyuto/.NET-Config/commit/42fc6282379a5a0d19081fe6dd292e5d03008975))

## [1.1.0](https://github.com/Kiruyuto/.NET-Config/compare/config-1.0.0...config-1.1.0) (2025-08-16)


### 🚀 Features & Enhancements

* Add various global `.editorconfigs` ([#13](https://github.com/Kiruyuto/.NET-Config/issues/13)) ([485add3](https://github.com/Kiruyuto/.NET-Config/commit/485add362859df1c7d365cf5d94569d9c355d7b9))

## 1.0.0 (2025-08-16)


### 🚀 Features & Enhancements

* Add basic config ([#1](https://github.com/Kiruyuto/.NET-Config/issues/1)) ([3226395](https://github.com/Kiruyuto/.NET-Config/commit/3226395f600bfd2fc3d4a1a95212b88411905dcc))


### 🤖 CI/CD

* Add 'Push to nuget' release step ([496dd85](https://github.com/Kiruyuto/.NET-Config/commit/496dd85bb1e0e7cae4e4e3dcaefade75d7aa0a33))
* Add `CI` workflow ([2f4296c](https://github.com/Kiruyuto/.NET-Config/commit/2f4296c4f78ce2f9050d365476eb732e8c747aff))
* Add `PR Management` workflow ([#2](https://github.com/Kiruyuto/.NET-Config/issues/2)) ([622ce9a](https://github.com/Kiruyuto/.NET-Config/commit/622ce9ad831c9b22195dd51fb52518d9f13eef27))
* Add `release-please` config ([19c1c9d](https://github.com/Kiruyuto/.NET-Config/commit/19c1c9d684f8276cfc77cb31cc67d9565b8a8923))
* Add CODEOWNERS & renovate config ([d13a05d](https://github.com/Kiruyuto/.NET-Config/commit/d13a05d3380c59a938e09b49a1336d2933d73838))
* Add release workflow ([#4](https://github.com/Kiruyuto/.NET-Config/issues/4)) ([fdcf3ba](https://github.com/Kiruyuto/.NET-Config/commit/fdcf3ba0e77cd505dc9f868561ad993dac510a63))
* Disable draft release PRs ([fdcf3ba](https://github.com/Kiruyuto/.NET-Config/commit/fdcf3ba0e77cd505dc9f868561ad993dac510a63))
* Fix `release-please` config ([fdcf3ba](https://github.com/Kiruyuto/.NET-Config/commit/fdcf3ba0e77cd505dc9f868561ad993dac510a63))
* Fix invalid `.nuspec` file path ([fdcf3ba](https://github.com/Kiruyuto/.NET-Config/commit/fdcf3ba0e77cd505dc9f868561ad993dac510a63))
* Fix missing version ([da96620](https://github.com/Kiruyuto/.NET-Config/commit/da9662005fcd0501cc44f33cb197ab90d1d225d0))
* Fix xpath ([fdcf3ba](https://github.com/Kiruyuto/.NET-Config/commit/fdcf3ba0e77cd505dc9f868561ad993dac510a63))
* Remove `space` from component name ([fdcf3ba](https://github.com/Kiruyuto/.NET-Config/commit/fdcf3ba0e77cd505dc9f868561ad993dac510a63))
* Remove comments from `.nuspec` file causing`release-please` to fail ([fdcf3ba](https://github.com/Kiruyuto/.NET-Config/commit/fdcf3ba0e77cd505dc9f868561ad993dac510a63))
* Remove unused `release-please` property ([96ad9ac](https://github.com/Kiruyuto/.NET-Config/commit/96ad9ac60df025ae5910af4e2347a214ac57328c))
* Use absolute path for files ([6521aae](https://github.com/Kiruyuto/.NET-Config/commit/6521aaee1ef3b2c26ebd8a0e8dfcdb82feec64aa))
* Use dynamic version from command input ([5a0fbac](https://github.com/Kiruyuto/.NET-Config/commit/5a0fbac7b31a11dabd6be749a804c76c0c262aff))


### 🏡 Chore

* **dependencies:** Pin nuget/setup-nuget action to 323ab05 (ci) ([#6](https://github.com/Kiruyuto/.NET-Config/issues/6)) ([fdcf3ba](https://github.com/Kiruyuto/.NET-Config/commit/fdcf3ba0e77cd505dc9f868561ad993dac510a63))
* **dependencies:** Update all non-major dependencies ([#10](https://github.com/Kiruyuto/.NET-Config/issues/10)) ([263af1a](https://github.com/Kiruyuto/.NET-Config/commit/263af1a5ed57d15d37fb2a267ea453ead25d5659))
* **dependencies:** Update dependency Microsoft.CodeAnalysis.BannedApiAnalyzers to v4 ([#11](https://github.com/Kiruyuto/.NET-Config/issues/11)) ([cecffd8](https://github.com/Kiruyuto/.NET-Config/commit/cecffd812b8448afa96b8f7bf79f833cf9a9ede4))
* Update descriptions ([872f1bd](https://github.com/Kiruyuto/.NET-Config/commit/872f1bdcdc15378a650e46251c66ef096e16df33))
