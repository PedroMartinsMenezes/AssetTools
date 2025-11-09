robocopy C:\Epic\UE_4.10 C:\UEFiles\UE410 *.uasset *.umap /S

cd C:\UEFiles\UE410
dir /b /s *.uasset > UE410_Files.txt
dir /b /s *.umap > UE410_Map_Files.txt

robocopy C:\UEFiles\UE410 C:\UE\AssetTools\AssetTool.Test\InputFiles UE410_Files.txt
robocopy C:\UEFiles\UE410 C:\UE\AssetTools\AssetTool.Test\InputFiles UE410_Map_Files.txt