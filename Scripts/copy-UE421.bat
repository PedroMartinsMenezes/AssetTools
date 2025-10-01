robocopy C:\Epic\UE_4.21 C:\UEFiles\UE421 *.uasset *.umap /S

cd C:\UEFiles\UE421
dir /b /s *.uasset > UE421_Files.txt
dir /b /s *.umap > UE421_Map_Files.txt

robocopy C:\UEFiles\UE421 C:\UE\AssetTools\AssetTool.Test\InputFiles UE421_Files.txt
robocopy C:\UEFiles\UE421 C:\UE\AssetTools\AssetTool.Test\InputFiles UE421_Map_Files.txt