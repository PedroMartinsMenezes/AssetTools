robocopy C:\Epic\UE_4.8 C:\UEFiles\UE408 *.uasset *.umap /S

cd C:\UEFiles\UE408
dir /b /s *.uasset > UE408_Files.txt
dir /b /s *.umap > UE408_Map_Files.txt

robocopy C:\UEFiles\UE408 C:\UE\AssetTools\AssetTool.Test\InputFiles UE408_Files.txt
robocopy C:\UEFiles\UE408 C:\UE\AssetTools\AssetTool.Test\InputFiles UE408_Map_Files.txt