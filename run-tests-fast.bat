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

echo Running tests in parallel...

start "CookedTest" /B cmd /c "dotnet test --no-build --filter ""FullyQualifiedName~AssetTool.Test.CookedTest"" --configuration Release --verbosity quiet >nul 2>&1 && echo StackOBotCookedTests: SUCCESS || echo StackOBotCookedTests: FAIL & echo.>CookedTest.done"

start "QuickTest" /B cmd /c "dotnet test --no-build --filter ""FullyQualifiedName~AssetTool.Test.QuickTest"" --configuration Release --verbosity quiet >nul 2>&1 && echo QuickTest: SUCCESS || echo QuickTest: FAIL & echo.>QuickTest.done"

start "SamplesTest" /B cmd /c "dotnet test --no-build --filter ""FullyQualifiedName~AssetTool.Test.SamplesTest"" --configuration Release --verbosity quiet >nul 2>&1 && echo SamplesTest: SUCCESS || echo SamplesTest: FAIL & echo.>SamplesTest.done"

start "UAssetAPITest" /B cmd /c "dotnet test --no-build --filter ""FullyQualifiedName~AssetTool.Test.UAssetAPITest"" --configuration Release --verbosity quiet >nul 2>&1 && echo UAssetAPITest: SUCCESS || echo UAssetAPITest: FAIL & echo.>UAssetAPITest.done"

start "UE4Tests" /B cmd /c "dotnet test --no-build --filter ""FullyQualifiedName~AssetTool.Test.UE4Tests"" --configuration Release --verbosity quiet >nul 2>&1 && echo UE4Tests: SUCCESS || echo UE4Tests: FAIL & echo.>UE4Tests.done"

start "UE5Tests" /B cmd /c "dotnet test --no-build --filter ""FullyQualifiedName~AssetTool.Test.UE5Tests"" --configuration Release --verbosity quiet >nul 2>&1 && echo UE5Tests: SUCCESS || echo UE5Tests: FAIL & echo.>UE5Tests.done"

:wait
if not exist CookedTest.done goto wait
if not exist QuickTest.done goto wait
if not exist SamplesTest.done goto wait
if not exist UAssetAPITest.done goto wait
if not exist UE4Tests.done goto wait
if not exist UE5Tests.done goto wait

set END=%TIME%

for /f "tokens=1-4 delims=:., " %%a in ("%START%") do (
    set /a STARTSEC=(((%%a*60)+%%b)*60)+%%c
)

for /f "tokens=1-4 delims=:., " %%a in ("%END%") do (
    set /a ENDSEC=(((%%a*60)+%%b)*60)+%%c
)

set /a ELAPSED=ENDSEC-STARTSEC
if !ELAPSED! lss 0 set /a ELAPSED+=86400

echo.
echo ==================================
echo Tempo total: !ELAPSED! segundos
echo ==================================

del /q *.done

pause