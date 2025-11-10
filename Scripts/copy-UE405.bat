robocopy C:\Epic\UE_4.5 C:\UEFiles\UE405 *.uasset *.umap /S

cd C:\UEFiles\UE405
dir /b /s *.uasset > UE405_Files.txt
dir /b /s *.umap > UE405_Map_Files.txt

robocopy C:\UEFiles\UE405 C:\UE\AssetTools\AssetTool.Test\InputFiles UE405_Files.txt
robocopy C:\UEFiles\UE405 C:\UE\AssetTools\AssetTool.Test\InputFiles UE405_Map_Files.txt