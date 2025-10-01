robocopy C:\Epic\UE_4.20 C:\UEFiles\UE420 *.uasset *.umap /S

cd C:\UEFiles\UE420
dir /b /s *.uasset > UE420_Files.txt
dir /b /s *.umap > UE420_Map_Files.txt

robocopy C:\UEFiles\UE420 C:\UE\AssetTools\AssetTool.Test\InputFiles UE420_Files.txt
robocopy C:\UEFiles\UE420 C:\UE\AssetTools\AssetTool.Test\InputFiles UE420_Map_Files.txt