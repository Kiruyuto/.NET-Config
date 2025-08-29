# Changelog

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
