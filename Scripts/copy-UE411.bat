robocopy C:\Epic\UE_4.11 C:\UEFiles\UE411 *.uasset *.umap /S

cd C:\UEFiles\UE411
dir /b /s *.uasset > UE411_Files.txt
dir /b /s *.umap > UE411_Map_Files.txt

robocopy C:\UEFiles\UE411 C:\UE\AssetTools\AssetTool.Test\InputFiles UE411_Files.txt
robocopy C:\UEFiles\UE411 C:\UE\AssetTools\AssetTool.Test\InputFiles UE411_Map_Files.txt