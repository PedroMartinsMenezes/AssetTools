robocopy C:\Epic\UE_4.23 C:\UEFiles\UE423 *.uasset *.umap /S

cd C:\UEFiles\UE423
dir /b /s *.uasset > UE423_Files.txt
dir /b /s *.umap > UE423_Map_Files.txt

robocopy C:\UEFiles\UE423 C:\UE\AssetTools\AssetTool.Test\InputFiles UE423_Files.txt
robocopy C:\UEFiles\UE423 C:\UE\AssetTools\AssetTool.Test\InputFiles UE423_Map_Files.txt