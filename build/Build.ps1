$ErrorActionPreference = "Stop"
$RuntimeIdentifier = "win-x64"
$Configuration = "Release"

# Locate the solution root (one level above the build folder).
$RepoRoot = Split-Path -Parent $PSScriptRoot
$ProjectPath = Join-Path $RepoRoot "Desktop application\Desktop application.csproj"
$PublishDir = Join-Path $RepoRoot "artifacts\$RuntimeIdentifier"

try {
    if (-not (Test-Path $ProjectPath)) {
        throw "UI project not found: $ProjectPath"
    }

    if (Test-Path $PublishDir) {
        Remove-Item $PublishDir -Recurse -Force
    }

    New-Item -ItemType Directory -Path $PublishDir -Force |
        Out-Null

    & dotnet publish $ProjectPath `
        --configuration $Configuration `
        --runtime $RuntimeIdentifier `
        --self-contained false `
        --output $PublishDir `
        -p:UseAppHost=true `
        "-p:PublishSingleFile=true" `
        "-p:PublishReadyToRun=true" `
        "-p:PublishReferencesDocumentationFiles=false" `
        "-p:AllowedReferenceRelatedFileExtensions=.pdb"

    if ($LASTEXITCODE -ne 0) {
        throw "dotnet publish failed with exit code $LASTEXITCODE."
    }

    # Documentation files (generated for code-style analysis) and debug symbols are not needed at runtime.
    Remove-Item (Join-Path $PublishDir "*") -Include "*.xml", "*.pdb" -Force

    Write-Host "Publish completed: $PublishDir" -ForegroundColor Green
}
catch {
    Write-Host "BUILD FAILED: $_" -ForegroundColor Red
    exit 1
}
finally {
    if ($Host.Name -eq "ConsoleHost") {
        Read-Host "Press Enter to close"
    }
}