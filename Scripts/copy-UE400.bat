robocopy C:\Epic\UE_4.0 C:\UEFiles\UE400 *.uasset *.umap /S

cd C:\UEFiles\UE400
dir /b /s *.uasset > UE400_Files.txt
dir /b /s *.umap > UE400_Map_Files.txt

robocopy C:\UEFiles\UE400 C:\UE\AssetTools\AssetTool.Test\InputFiles UE400_Files.txt
robocopy C:\UEFiles\UE400 C:\UE\AssetTools\AssetTool.Test\InputFiles UE400_Map_Files.txt