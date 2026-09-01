dotnet test --filter "FullyQualifiedName~AssetTool.Test.CookedTest" --verbosity quiet >nul 2>&1 && echo StackOBotCookedTests: SUCCESS || echo StackOBotCookedTests: FAIL

dotnet test --filter "FullyQualifiedName~AssetTool.Test.QuickTest" --verbosity quiet >nul 2>&1 && echo QuickTest: SUCCESS || echo QuickTest: FAIL

dotnet test --filter "FullyQualifiedName~AssetTool.Test.SamplesTest" --verbosity quiet >nul 2>&1 && echo SamplesTest: SUCCESS || echo SamplesTest: FAIL

dotnet test --filter "FullyQualifiedName~AssetTool.Test.UAssetAPITest" --verbosity quiet >nul 2>&1 && echo UAssetAPITest: SUCCESS || echo UAssetAPITest: FAIL

dotnet test --filter "FullyQualifiedName~AssetTool.Test.UE4Tests" --verbosity quiet >nul 2>&1 && echo UE4Tests: SUCCESS || echo UE4Tests: FAIL

dotnet test --filter "FullyQualifiedName~AssetTool.Test.UE5Tests" --verbosity quiet >nul 2>&1 && echo UE5Tests: SUCCESS || echo UE5Tests: FAIL