@echo off
setlocal EnableDelayedExpansion

set START=%TIME%

if exist *.done del /q *.done

echo Building...
dotnet build -c Release
if errorlevel 1 (
    echo BUILD: FAIL
    pause
    exit /b 1
)

echo %TIME%
echo Running tests in parallel...

echo %TIME%
start "CookedTest" /B cmd /c "dotnet test --no-build --filter ""FullyQualifiedName~AssetTool.Test.CookedTest"" --configuration Release --verbosity quiet >nul 2>&1 && echo StackOBotCookedTests: SUCCESS || echo StackOBotCookedTests: FAIL & echo.>CookedTest.done"
echo %TIME%
start "QuickTest" /B cmd /c "dotnet test --no-build --filter ""FullyQualifiedName~AssetTool.Test.QuickTest"" --configuration Release --verbosity quiet >nul 2>&1 && echo QuickTest: SUCCESS || echo QuickTest: FAIL & echo.>QuickTest.done"
echo %TIME%
start "SamplesTest" /B cmd /c "dotnet test --no-build --filter ""FullyQualifiedName~AssetTool.Test.SamplesTest"" --configuration Release --verbosity quiet >nul 2>&1 && echo SamplesTest: SUCCESS || echo SamplesTest: FAIL & echo.>SamplesTest.done"
echo %TIME%
start "UAssetAPITest" /B cmd /c "dotnet test --no-build --filter ""FullyQualifiedName~AssetTool.Test.UAssetAPITest"" --configuration Release --verbosity quiet >nul 2>&1 && echo UAssetAPITest: SUCCESS || echo UAssetAPITest: FAIL & echo.>UAssetAPITest.done"
echo %TIME%
start "UE4Tests" /B cmd /c "dotnet test --no-build --filter ""FullyQualifiedName~AssetTool.Test.UE4Tests"" --configuration Release --verbosity quiet >nul 2>&1 && echo UE4Tests: SUCCESS || echo UE4Tests: FAIL & echo.>UE4Tests.done"
echo %TIME%
start "UE5Tests" /B cmd /c "dotnet test --no-build --filter ""FullyQualifiedName~AssetTool.Test.UE5Tests"" --configuration Release --verbosity quiet >nul 2>&1 && echo UE5Tests: SUCCESS || echo UE5Tests: FAIL & echo.>UE5Tests.done"
echo %TIME%

:wait
if not exist CookedTest.done goto wait
if not exist QuickTest.done goto wait
if not exist SamplesTest.done goto wait
if not exist UAssetAPITest.done goto wait
if not exist UE4Tests.done goto wait
if not exist UE5Tests.done goto wait

echo All tests completed

del /q *.done

pause