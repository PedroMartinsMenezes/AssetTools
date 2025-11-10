robocopy C:\Epic\UE_4.4 C:\UEFiles\UE404 *.uasset *.umap /S

cd C:\UEFiles\UE404
dir /b /s *.uasset > UE404_Files.txt
dir /b /s *.umap > UE404_Map_Files.txt

robocopy C:\UEFiles\UE404 C:\UE\AssetTools\AssetTool.Test\InputFiles UE404_Files.txt
robocopy C:\UEFiles\UE404 C:\UE\AssetTools\AssetTool.Test\InputFiles UE404_Map_Files.txt