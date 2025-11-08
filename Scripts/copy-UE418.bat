robocopy C:\Epic\UE_4.18 C:\UEFiles\UE418 *.uasset *.umap /S

cd C:\UEFiles\UE418
dir /b /s *.uasset > UE418_Files.txt
dir /b /s *.umap > UE418_Map_Files.txt

robocopy C:\UEFiles\UE418 C:\UE\AssetTools\AssetTool.Test\InputFiles UE418_Files.txt
robocopy C:\UEFiles\UE418 C:\UE\AssetTools\AssetTool.Test\InputFiles UE418_Map_Files.txt