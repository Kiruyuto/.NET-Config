$nugetExePath = ".\nuget.exe"
$feedName = "KiruyutoDotNetConfigLocalFeed"
$packagePattern = "Kiruyuto.DotNet.Config.*.nupkg"

# Remove the local NuGet feed
Write-Host "Removing local NuGet feed '$feedName'..."
$existingSource = & $nugetExePath sources list | Select-String -Pattern $feedName
if ($existingSource) {
    & $nugetExePath sources remove -Name $feedName
    Write-Host "Feed '$feedName' removed successfully" -ForegroundColor Green
} else {
    Write-Host "Feed '$feedName' does not exist" -ForegroundColor Red
}

# Remove packed package files
Write-Host "Removing packed package files..."
$projectRoot = Split-Path $PSScriptRoot -Parent
$packages = Get-ChildItem -Path $projectRoot -Filter $packagePattern
if ($packages) {
    foreach ($package in $packages) {
        Remove-Item $package.FullName -Force
        Write-Host "Removed: $($package.Name)" -ForegroundColor Green
    }
} else {
    Write-Host "No package files found to remove" -ForegroundColor Red
}

Write-Host "Successfully unregistered and package files removed" -ForegroundColor Green
