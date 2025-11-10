robocopy C:\Epic\UE_4.7 C:\UEFiles\UE407 *.uasset *.umap /S

cd C:\UEFiles\UE407
dir /b /s *.uasset > UE407_Files.txt
dir /b /s *.umap > UE407_Map_Files.txt

robocopy C:\UEFiles\UE407 C:\UE\AssetTools\AssetTool.Test\InputFiles UE407_Files.txt
robocopy C:\UEFiles\UE407 C:\UE\AssetTools\AssetTool.Test\InputFiles UE407_Map_Files.txt