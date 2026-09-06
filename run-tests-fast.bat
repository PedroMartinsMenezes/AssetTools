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

set CookedTest.done=
set QuickTest.done=
set SamplesTest.done=
set UAssetAPITest.done=
set UE400to409Tests.done=
set UE410to419Tests.done=
set UE420to427Tests.done=
set UE5Tests.done=

start "CookedTest" /B cmd /c "dotnet test --no-build --filter ""FullyQualifiedName~AssetTool.Test.CookedTest"" --configuration Release --verbosity quiet >nul 2>&1 && echo CookedTest: SUCCESS || echo CookedTest: FAIL & echo.>CookedTest.done"

start "QuickTest" /B cmd /c "dotnet test --no-build --filter ""FullyQualifiedName~AssetTool.Test.QuickTest"" --configuration Release --verbosity quiet >nul 2>&1 && echo QuickTest: SUCCESS || echo QuickTest: FAIL & echo.>QuickTest.done"

start "SamplesTest" /B cmd /c "dotnet test --no-build --filter ""FullyQualifiedName~AssetTool.Test.SamplesTest"" --configuration Release --verbosity quiet >nul 2>&1 && echo SamplesTest: SUCCESS || echo SamplesTest: FAIL & echo.>SamplesTest.done"

start "UAssetAPITest" /B cmd /c "dotnet test --no-build --filter ""FullyQualifiedName~AssetTool.Test.UAssetAPITest"" --configuration Release --verbosity quiet >nul 2>&1 && echo UAssetAPITest: SUCCESS || echo UAssetAPITest: FAIL & echo.>UAssetAPITest.done"

start "UE400to409Tests" /B cmd /c "dotnet test --no-build --filter ""FullyQualifiedName~AssetTool.Test.UE400to409Tests"" --configuration Release --verbosity quiet >nul 2>&1 && echo UE400to409Tests: SUCCESS || echo UE400to409Tests: FAIL & echo.>UE400to409Tests.done"

start "UE410to419Tests" /B cmd /c "dotnet test --no-build --filter ""FullyQualifiedName~AssetTool.Test.UE410to419Tests"" --configuration Release --verbosity quiet >nul 2>&1 && echo UE410to419Tests: SUCCESS || echo UE410to419Tests: FAIL & echo.>UE410to419Tests.done"

start "UE420to427Tests" /B cmd /c "dotnet test --no-build --filter ""FullyQualifiedName~AssetTool.Test.UE420to427Tests"" --configuration Release --verbosity quiet >nul 2>&1 && echo UE420to427Tests: SUCCESS || echo UE420to427Tests: FAIL & echo.>UE420to427Tests.done"

start "UE5Tests" /B cmd /c "dotnet test --no-build --filter ""FullyQualifiedName~AssetTool.Test.UE5Tests"" --configuration Release --verbosity quiet >nul 2>&1 && echo UE5Tests: SUCCESS || echo UE5Tests: FAIL & echo.>UE5Tests.done"


:wait
if not exist CookedTest.done (
    goto wait
) else (
    if not defined CookedTest.done (
        echo %TIME% - CookedTest completed
        set CookedTest.done=1
    )
)
if not exist QuickTest.done (
    goto wait
) else (
    if not defined QuickTest.done (
        echo %TIME% - QuickTest completed
        set QuickTest.done=1
    )
)
if not exist SamplesTest.done (
    goto wait
) else (
    if not defined SamplesTest.done (
        echo %TIME% - SamplesTest completed
        set SamplesTest.done=1
    )
)
if not exist UAssetAPITest.done (
    goto wait
) else (
    if not defined UAssetAPITest.done (
        echo %TIME% - UAssetAPITest completed
        set UAssetAPITest.done=1
    )
)
if not exist UE400to409Tests.done (
    goto wait
) else (
    if not defined UE400to409Tests.done (
        echo %TIME% - UE400to409Tests completed
        set UE400to409Tests.done=1
    )
)
if not exist UE410to419Tests.done (
    goto wait
) else (
    if not defined UE410to419Tests.done (
        echo %TIME% - UE410to419Tests completed
        set UE410to419Tests.done=1
    )
)
if not exist UE420to427Tests.done (
    goto wait
) else (
    if not defined UE420to427Tests.done (
        echo %TIME% - UE420to427Tests completed
        set UE420to427Tests.done=1
    )
)
if not exist UE5Tests.done (
    goto wait
) else (
    if not defined UE5Tests.done (
        echo %TIME% - UE5Tests completed
        set UE5Tests.done=1
    )
)

echo All tests completed
echo %TIME%

del /q *.done

pause