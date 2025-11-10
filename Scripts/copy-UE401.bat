robocopy C:\Epic\UE_4.1 C:\UEFiles\UE401 *.uasset *.umap /S

cd C:\UEFiles\UE401
dir /b /s *.uasset > UE401_Files.txt
dir /b /s *.umap > UE401_Map_Files.txt

robocopy C:\UEFiles\UE401 C:\UE\AssetTools\AssetTool.Test\InputFiles UE401_Files.txt
robocopy C:\UEFiles\UE401 C:\UE\AssetTools\AssetTool.Test\InputFiles UE401_Map_Files.txt