robocopy C:\Epic\UE_4.13 C:\UEFiles\UE413 *.uasset *.umap /S

cd C:\UEFiles\UE413
dir /b /s *.uasset > UE413_Files.txt
dir /b /s *.umap > UE413_Map_Files.txt

robocopy C:\UEFiles\UE413 C:\UE\AssetTools\AssetTool.Test\InputFiles UE413_Files.txt
robocopy C:\UEFiles\UE413 C:\UE\AssetTools\AssetTool.Test\InputFiles UE413_Map_Files.txt