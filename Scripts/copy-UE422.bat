robocopy C:\Epic\UE_4.22 C:\UEFiles\UE422 *.uasset *.umap /S

cd C:\UEFiles\UE422
dir /b /s *.uasset > UE422_Files.txt
dir /b /s *.umap > UE422_Map_Files.txt

robocopy C:\UEFiles\UE422 C:\UE\AssetTools\AssetTool.Test\InputFiles UE422_Files.txt
robocopy C:\UEFiles\UE422 C:\UE\AssetTools\AssetTool.Test\InputFiles UE422_Map_Files.txt