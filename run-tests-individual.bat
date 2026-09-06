@echo off

dotnet test --filter "FullyQualifiedName~AssetTool.Test.CookedTest" --configuration Release --verbosity quiet >nul 2>&1 && echo StackOBotCookedTests: SUCCESS || echo StackOBotCookedTests: FAIL

dotnet test --filter "FullyQualifiedName~AssetTool.Test.SamplesTest" --configuration Release --verbosity quiet >nul 2>&1 && echo SamplesTest: SUCCESS || echo SamplesTest: FAIL

dotnet test --filter "FullyQualifiedName~AssetTool.Test.UAssetAPITest" --configuration Release --verbosity quiet >nul 2>&1 && echo UAssetAPITest: SUCCESS || echo UAssetAPITest: FAIL

:: QuickTest
dotnet test --filter "FullyQualifiedName~AssetTool.Test.QuickTest.QuickBlueprintTests.Test_01_Blueprints_UE4" --configuration Release --verbosity quiet >nul 2>&1 && echo Test_01_Blueprints_UE4: SUCCESS || echo Test_01_Blueprints_UE4: FAIL
dotnet test --filter "FullyQualifiedName~AssetTool.Test.QuickTest.QuickBlueprintTests.Test_02_Blueprints_UE5" --configuration Release --verbosity quiet >nul 2>&1 && echo Test_02_Blueprints_UE5: SUCCESS || echo Test_02_Blueprints_UE5: FAIL
dotnet test --filter "FullyQualifiedName~AssetTool.Test.QuickTest.QuickBlueprintTests.Test_03_Blueprints_Others" --configuration Release --verbosity quiet >nul 2>&1 && echo Test_03_Blueprints_Others: SUCCESS || echo Test_03_Blueprints_Others: FAIL
dotnet test --filter "FullyQualifiedName~AssetTool.Test.QuickTest.QuickSequentialTests.Test_01_RunUassetToJson" --configuration Release --verbosity quiet >nul 2>&1 && echo Test_01_RunUassetToJson: SUCCESS || echo Test_01_RunUassetToJson: FAIL
dotnet test --filter "FullyQualifiedName~AssetTool.Test.QuickTest.QuickSequentialTests.Test_02_RunJsonToUasset" --configuration Release --verbosity quiet >nul 2>&1 && echo Test_02_RunJsonToUasset: SUCCESS || echo Test_02_RunJsonToUasset: FAIL
dotnet test --filter "FullyQualifiedName~AssetTool.Test.QuickTest.QuickSequentialTests.Test_03_QuickTest_Files" --configuration Release --verbosity quiet >nul 2>&1 && echo Test_03_QuickTest_Files: SUCCESS || echo Test_03_QuickTest_Files: FAIL

:: UE4Tests Maps
dotnet test --filter "FullyQualifiedName~AssetTool.Test.UE4Tests.UE400MapTests.Test_UE400_Maps" --configuration Release --verbosity quiet >nul 2>&1 && echo UE400MapTests: SUCCESS || echo UE400MapTests: FAIL
dotnet test --filter "FullyQualifiedName~AssetTool.Test.UE4Tests.UE401MapTests.Test_UE401_Maps" --configuration Release --verbosity quiet >nul 2>&1 && echo UE401MapTests: SUCCESS || echo UE401MapTests: FAIL
dotnet test --filter "FullyQualifiedName~AssetTool.Test.UE4Tests.UE402MapTests.Test_UE402_Maps" --configuration Release --verbosity quiet >nul 2>&1 && echo UE402MapTests: SUCCESS || echo UE402MapTests: FAIL
dotnet test --filter "FullyQualifiedName~AssetTool.Test.UE4Tests.UE403MapTests.Test_UE403_Maps" --configuration Release --verbosity quiet >nul 2>&1 && echo UE403MapTests: SUCCESS || echo UE403MapTests: FAIL
dotnet test --filter "FullyQualifiedName~AssetTool.Test.UE4Tests.UE404MapTests.Test_UE404_Maps" --configuration Release --verbosity quiet >nul 2>&1 && echo UE404MapTests: SUCCESS || echo UE404MapTests: FAIL
dotnet test --filter "FullyQualifiedName~AssetTool.Test.UE4Tests.UE405MapTests.Test_UE405_Maps" --configuration Release --verbosity quiet >nul 2>&1 && echo UE405MapTests: SUCCESS || echo UE405MapTests: FAIL
dotnet test --filter "FullyQualifiedName~AssetTool.Test.UE4Tests.UE406MapTests.Test_UE406_Maps" --configuration Release --verbosity quiet >nul 2>&1 && echo UE406MapTests: SUCCESS || echo UE406MapTests: FAIL
dotnet test --filter "FullyQualifiedName~AssetTool.Test.UE4Tests.UE407MapTests.Test_UE407_Maps" --configuration Release --verbosity quiet >nul 2>&1 && echo UE407MapTests: SUCCESS || echo UE407MapTests: FAIL
dotnet test --filter "FullyQualifiedName~AssetTool.Test.UE4Tests.UE408MapTests.Test_UE408_Maps" --configuration Release --verbosity quiet >nul 2>&1 && echo UE408MapTests: SUCCESS || echo UE408MapTests: FAIL
dotnet test --filter "FullyQualifiedName~AssetTool.Test.UE4Tests.UE409MapTests.Test_UE409_Maps" --configuration Release --verbosity quiet >nul 2>&1 && echo UE409MapTests: SUCCESS || echo UE409MapTests: FAIL
dotnet test --filter "FullyQualifiedName~AssetTool.Test.UE4Tests.UE410MapTests.Test_UE410_Maps" --configuration Release --verbosity quiet >nul 2>&1 && echo UE410MapTests: SUCCESS || echo UE410MapTests: FAIL
dotnet test --filter "FullyQualifiedName~AssetTool.Test.UE4Tests.UE411MapTests.Test_UE411_Maps" --configuration Release --verbosity quiet >nul 2>&1 && echo UE411MapTests: SUCCESS || echo UE411MapTests: FAIL
dotnet test --filter "FullyQualifiedName~AssetTool.Test.UE4Tests.UE412MapTests.Test_UE412_Maps" --configuration Release --verbosity quiet >nul 2>&1 && echo UE412MapTests: SUCCESS || echo UE412MapTests: FAIL
dotnet test --filter "FullyQualifiedName~AssetTool.Test.UE4Tests.UE413MapTests.Test_UE413_Maps" --configuration Release --verbosity quiet >nul 2>&1 && echo UE413MapTests: SUCCESS || echo UE413MapTests: FAIL
dotnet test --filter "FullyQualifiedName~AssetTool.Test.UE4Tests.UE414MapTests.Test_UE414_Maps" --configuration Release --verbosity quiet >nul 2>&1 && echo UE414MapTests: SUCCESS || echo UE414MapTests: FAIL
dotnet test --filter "FullyQualifiedName~AssetTool.Test.UE4Tests.UE415MapTests.Test_UE415_Maps" --configuration Release --verbosity quiet >nul 2>&1 && echo UE415MapTests: SUCCESS || echo UE415MapTests: FAIL
dotnet test --filter "FullyQualifiedName~AssetTool.Test.UE4Tests.UE416MapTests.Test_UE416_Maps" --configuration Release --verbosity quiet >nul 2>&1 && echo UE416MapTests: SUCCESS || echo UE416MapTests: FAIL
dotnet test --filter "FullyQualifiedName~AssetTool.Test.UE4Tests.UE417MapTests.Test_UE417_Maps" --configuration Release --verbosity quiet >nul 2>&1 && echo UE417MapTests: SUCCESS || echo UE417MapTests: FAIL
dotnet test --filter "FullyQualifiedName~AssetTool.Test.UE4Tests.UE418MapTests.Test_UE418_Maps" --configuration Release --verbosity quiet >nul 2>&1 && echo UE418MapTests: SUCCESS || echo UE418MapTests: FAIL
dotnet test --filter "FullyQualifiedName~AssetTool.Test.UE4Tests.UE419MapTests.Test_UE419_Maps" --configuration Release --verbosity quiet >nul 2>&1 && echo UE419MapTests: SUCCESS || echo UE419MapTests: FAIL
dotnet test --filter "FullyQualifiedName~AssetTool.Test.UE4Tests.UE420MapTests.Test_UE420_Maps" --configuration Release --verbosity quiet >nul 2>&1 && echo UE420MapTests: SUCCESS || echo UE420MapTests: FAIL
dotnet test --filter "FullyQualifiedName~AssetTool.Test.UE4Tests.UE421MapTests.Test_UE421_Maps" --configuration Release --verbosity quiet >nul 2>&1 && echo UE421MapTests: SUCCESS || echo UE421MapTests: FAIL
dotnet test --filter "FullyQualifiedName~AssetTool.Test.UE4Tests.UE422MapTests.Test_UE422_Maps" --configuration Release --verbosity quiet >nul 2>&1 && echo UE422MapTests: SUCCESS || echo UE422MapTests: FAIL
dotnet test --filter "FullyQualifiedName~AssetTool.Test.UE4Tests.UE423MapTests.Test_UE423_Maps" --configuration Release --verbosity quiet >nul 2>&1 && echo UE423MapTests: SUCCESS || echo UE423MapTests: FAIL
dotnet test --filter "FullyQualifiedName~AssetTool.Test.UE4Tests.UE424MapTests.Test_UE424_Maps" --configuration Release --verbosity quiet >nul 2>&1 && echo UE424MapTests: SUCCESS || echo UE424MapTests: FAIL
dotnet test --filter "FullyQualifiedName~AssetTool.Test.UE4Tests.UE425MapTests.Test_UE425_Maps" --configuration Release --verbosity quiet >nul 2>&1 && echo UE425MapTests: SUCCESS || echo UE425MapTests: FAIL
dotnet test --filter "FullyQualifiedName~AssetTool.Test.UE4Tests.UE426MapTests.Test_UE426_Maps" --configuration Release --verbosity quiet >nul 2>&1 && echo UE426MapTests: SUCCESS || echo UE426MapTests: FAIL
dotnet test --filter "FullyQualifiedName~AssetTool.Test.UE4Tests.UE427MapTests.Test_UE427_Maps" --configuration Release --verbosity quiet >nul 2>&1 && echo UE427MapTests: SUCCESS || echo UE427MapTests: FAIL

:: UE4Tests Assets
dotnet test --filter "FullyQualifiedName~AssetTool.Test.UE4Tests.UE400AssetTests.Test_UE400_Assets" --configuration Release --verbosity quiet >nul 2>&1 && echo UE400AssetTests: SUCCESS || echo UE400AssetTests: FAIL
dotnet test --filter "FullyQualifiedName~AssetTool.Test.UE4Tests.UE401AssetTests.Test_UE401_Assets" --configuration Release --verbosity quiet >nul 2>&1 && echo UE401AssetTests: SUCCESS || echo UE401AssetTests: FAIL
dotnet test --filter "FullyQualifiedName~AssetTool.Test.UE4Tests.UE402AssetTests.Test_UE402_Assets" --configuration Release --verbosity quiet >nul 2>&1 && echo UE402AssetTests: SUCCESS || echo UE402AssetTests: FAIL
dotnet test --filter "FullyQualifiedName~AssetTool.Test.UE4Tests.UE403AssetTests.Test_UE403_Assets" --configuration Release --verbosity quiet >nul 2>&1 && echo UE403AssetTests: SUCCESS || echo UE403AssetTests: FAIL
dotnet test --filter "FullyQualifiedName~AssetTool.Test.UE4Tests.UE404AssetTests.Test_UE404_Assets" --configuration Release --verbosity quiet >nul 2>&1 && echo UE404AssetTests: SUCCESS || echo UE404AssetTests: FAIL
dotnet test --filter "FullyQualifiedName~AssetTool.Test.UE4Tests.UE405AssetTests.Test_UE405_Assets" --configuration Release --verbosity quiet >nul 2>&1 && echo UE405AssetTests: SUCCESS || echo UE405AssetTests: FAIL
dotnet test --filter "FullyQualifiedName~AssetTool.Test.UE4Tests.UE406AssetTests.Test_UE406_Assets" --configuration Release --verbosity quiet >nul 2>&1 && echo UE406AssetTests: SUCCESS || echo UE406AssetTests: FAIL
dotnet test --filter "FullyQualifiedName~AssetTool.Test.UE4Tests.UE407AssetTests.Test_UE407_Assets" --configuration Release --verbosity quiet >nul 2>&1 && echo UE407AssetTests: SUCCESS || echo UE407AssetTests: FAIL
dotnet test --filter "FullyQualifiedName~AssetTool.Test.UE4Tests.UE408AssetTests.Test_UE408_Assets" --configuration Release --verbosity quiet >nul 2>&1 && echo UE408AssetTests: SUCCESS || echo UE408AssetTests: FAIL
dotnet test --filter "FullyQualifiedName~AssetTool.Test.UE4Tests.UE409AssetTests.Test_UE409_Assets" --configuration Release --verbosity quiet >nul 2>&1 && echo UE409AssetTests: SUCCESS || echo UE409AssetTests: FAIL
dotnet test --filter "FullyQualifiedName~AssetTool.Test.UE4Tests.UE410AssetTests.Test_UE410_Assets" --configuration Release --verbosity quiet >nul 2>&1 && echo UE410AssetTests: SUCCESS || echo UE410AssetTests: FAIL
dotnet test --filter "FullyQualifiedName~AssetTool.Test.UE4Tests.UE411AssetTests.Test_UE411_Assets" --configuration Release --verbosity quiet >nul 2>&1 && echo UE411AssetTests: SUCCESS || echo UE411AssetTests: FAIL
dotnet test --filter "FullyQualifiedName~AssetTool.Test.UE4Tests.UE412AssetTests.Test_UE412_Assets" --configuration Release --verbosity quiet >nul 2>&1 && echo UE412AssetTests: SUCCESS || echo UE412AssetTests: FAIL
dotnet test --filter "FullyQualifiedName~AssetTool.Test.UE4Tests.UE413AssetTests.Test_UE413_Assets" --configuration Release --verbosity quiet >nul 2>&1 && echo UE413AssetTests: SUCCESS || echo UE413AssetTests: FAIL
dotnet test --filter "FullyQualifiedName~AssetTool.Test.UE4Tests.UE414AssetTests.Test_UE414_Assets" --configuration Release --verbosity quiet >nul 2>&1 && echo UE414AssetTests: SUCCESS || echo UE414AssetTests: FAIL
dotnet test --filter "FullyQualifiedName~AssetTool.Test.UE4Tests.UE415AssetTests.Test_UE415_Assets" --configuration Release --verbosity quiet >nul 2>&1 && echo UE415AssetTests: SUCCESS || echo UE415AssetTests: FAIL
dotnet test --filter "FullyQualifiedName~AssetTool.Test.UE4Tests.UE416AssetTests.Test_UE416_Assets" --configuration Release --verbosity quiet >nul 2>&1 && echo UE416AssetTests: SUCCESS || echo UE416AssetTests: FAIL
dotnet test --filter "FullyQualifiedName~AssetTool.Test.UE4Tests.UE417AssetTests.Test_UE417_Assets" --configuration Release --verbosity quiet >nul 2>&1 && echo UE417AssetTests: SUCCESS || echo UE417AssetTests: FAIL
dotnet test --filter "FullyQualifiedName~AssetTool.Test.UE4Tests.UE418AssetTests.Test_UE418_Assets" --configuration Release --verbosity quiet >nul 2>&1 && echo UE418AssetTests: SUCCESS || echo UE418AssetTests: FAIL
dotnet test --filter "FullyQualifiedName~AssetTool.Test.UE4Tests.UE419AssetTests.Test_UE419_Assets" --configuration Release --verbosity quiet >nul 2>&1 && echo UE419AssetTests: SUCCESS || echo UE419AssetTests: FAIL
dotnet test --filter "FullyQualifiedName~AssetTool.Test.UE4Tests.UE420AssetTests.Test_UE420_Assets" --configuration Release --verbosity quiet >nul 2>&1 && echo UE420AssetTests: SUCCESS || echo UE420AssetTests: FAIL
dotnet test --filter "FullyQualifiedName~AssetTool.Test.UE4Tests.UE421AssetTests.Test_UE421_Assets" --configuration Release --verbosity quiet >nul 2>&1 && echo UE421AssetTests: SUCCESS || echo UE421AssetTests: FAIL
dotnet test --filter "FullyQualifiedName~AssetTool.Test.UE4Tests.UE422AssetTests.Test_UE422_Assets" --configuration Release --verbosity quiet >nul 2>&1 && echo UE422AssetTests: SUCCESS || echo UE422AssetTests: FAIL
dotnet test --filter "FullyQualifiedName~AssetTool.Test.UE4Tests.UE423AssetTests.Test_UE423_Assets" --configuration Release --verbosity quiet >nul 2>&1 && echo UE423AssetTests: SUCCESS || echo UE423AssetTests: FAIL
dotnet test --filter "FullyQualifiedName~AssetTool.Test.UE4Tests.UE424AssetTests.Test_UE424_Assets" --configuration Release --verbosity quiet >nul 2>&1 && echo UE424AssetTests: SUCCESS || echo UE424AssetTests: FAIL
dotnet test --filter "FullyQualifiedName~AssetTool.Test.UE4Tests.UE425AssetTests.Test_UE425_Assets" --configuration Release --verbosity quiet >nul 2>&1 && echo UE425AssetTests: SUCCESS || echo UE425AssetTests: FAIL
dotnet test --filter "FullyQualifiedName~AssetTool.Test.UE4Tests.UE426AssetTests.Test_UE426_Assets" --configuration Release --verbosity quiet >nul 2>&1 && echo UE426AssetTests: SUCCESS || echo UE426AssetTests: FAIL
dotnet test --filter "FullyQualifiedName~AssetTool.Test.UE4Tests.UE427AssetTests.Test_UE427_Assets" --configuration Release --verbosity quiet >nul 2>&1 && echo UE427AssetTests: SUCCESS || echo UE427AssetTests: FAIL

:: UE5Tests Maps
dotnet test --filter "FullyQualifiedName~AssetTool.Test.UE5Tests.UE50MapTests.Test_UE50_Maps" --configuration Release --verbosity quiet >nul 2>&1 && echo UE50MapTests: SUCCESS || echo UE50MapTests: FAIL
dotnet test --filter "FullyQualifiedName~AssetTool.Test.UE5Tests.UE51MapTests.Test_UE51_Maps" --configuration Release --verbosity quiet >nul 2>&1 && echo UE51MapTests: SUCCESS || echo UE51MapTests: FAIL
dotnet test --filter "FullyQualifiedName~AssetTool.Test.UE5Tests.UE52MapTests.Test_UE52_Maps" --configuration Release --verbosity quiet >nul 2>&1 && echo UE52MapTests: SUCCESS || echo UE52MapTests: FAIL
dotnet test --filter "FullyQualifiedName~AssetTool.Test.UE5Tests.UE53MapTests.Test_UE53_Maps" --configuration Release --verbosity quiet >nul 2>&1 && echo UE53MapTests: SUCCESS || echo UE53MapTests: FAIL
dotnet test --filter "FullyQualifiedName~AssetTool.Test.UE5Tests.UE54MapTests.Test_UE54_Maps" --configuration Release --verbosity quiet >nul 2>&1 && echo UE54MapTests: SUCCESS || echo UE54MapTests: FAIL
dotnet test --filter "FullyQualifiedName~AssetTool.Test.UE5Tests.UE55MapTests.Test_UE55_Maps" --configuration Release --verbosity quiet >nul 2>&1 && echo UE55MapTests: SUCCESS || echo UE55MapTests: FAIL
dotnet test --filter "FullyQualifiedName~AssetTool.Test.UE5Tests.UE56MapTests.Test_UE56_Maps" --configuration Release --verbosity quiet >nul 2>&1 && echo UE56MapTests: SUCCESS || echo UE56MapTests: FAIL

:: UE5Tests Assets
dotnet test --filter "FullyQualifiedName~AssetTool.Test.UE5Tests.UE50AssetTests.Test_UE50_Assets" --configuration Release --verbosity quiet >nul 2>&1 && echo UE50AssetTests: SUCCESS || echo UE50AssetTests: FAIL
dotnet test --filter "FullyQualifiedName~AssetTool.Test.UE5Tests.UE51AssetTests.Test_UE51_Assets" --configuration Release --verbosity quiet >nul 2>&1 && echo UE51AssetTests: SUCCESS || echo UE51AssetTests: FAIL
dotnet test --filter "FullyQualifiedName~AssetTool.Test.UE5Tests.UE52AssetTests.Test_UE52_Assets" --configuration Release --verbosity quiet >nul 2>&1 && echo UE52AssetTests: SUCCESS || echo UE52AssetTests: FAIL
dotnet test --filter "FullyQualifiedName~AssetTool.Test.UE5Tests.UE53AssetTests.Test_UE53_Assets" --configuration Release --verbosity quiet >nul 2>&1 && echo UE53AssetTests: SUCCESS || echo UE53AssetTests: FAIL
dotnet test --filter "FullyQualifiedName~AssetTool.Test.UE5Tests.UE54AssetTests.Test_UE54_Assets" --configuration Release --verbosity quiet >nul 2>&1 && echo UE54AssetTests: SUCCESS || echo UE54AssetTests: FAIL
dotnet test --filter "FullyQualifiedName~AssetTool.Test.UE5Tests.UE55AssetTests.Test_UE55_Assets" --configuration Release --verbosity quiet >nul 2>&1 && echo UE55AssetTests: SUCCESS || echo UE55AssetTests: FAIL
dotnet test --filter "FullyQualifiedName~AssetTool.Test.UE5Tests.UE56AssetTests.Test_UE56_Assets" --configuration Release --verbosity quiet >nul 2>&1 && echo UE56AssetTests: SUCCESS || echo UE56AssetTests: FAIL

pause