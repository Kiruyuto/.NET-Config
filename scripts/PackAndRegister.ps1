$nugetExeLink = "https://dist.nuget.org/win-x86-commandline/latest/nuget.exe"
$nugetExePath = ".\nuget.exe"
$packageVersion = "0.0.1"
$feedName = "KiruyutoDotNetConfigLocalFeed"
$feedPath = Split-Path $PSScriptRoot -Parent

# Check if nuget.exe exists, if not download it
if (-not (Test-Path $nugetExePath)) {
    Write-Host "Downloading nuget.exe from $nugetExeLink..."
    Invoke-WebRequest -Uri $nugetExeLink -OutFile $nugetExePath
    Write-Host "'nuget.exe' downloaded successfully" -ForegroundColor Green
} else {
    Write-Host "'nuget.exe' already exists." -ForegroundColor Yellow
}

# Pack
Write-Host "Packing NuGet package..."
& $nugetExePath pack Kiruyuto.DotNet.Config.nuspec -ForceEnglishOutput -Version $packageVersion

# Register local NuGet feed
Write-Host "Registering local NuGet feed '$feedName'..."
$existingSource = & $nugetExePath sources list | Select-String -Pattern $feedName
if ($existingSource) {
    Write-Host "Feed '$feedName' already exists. Updating..." -ForegroundColor Yellow
    & $nugetExePath sources update -Name $feedName -Source $feedPath
} else {
    & $nugetExePath sources add -Name $feedName -Source $feedPath
}

Write-Host "Package created and local feed registered" -ForegroundColor Green