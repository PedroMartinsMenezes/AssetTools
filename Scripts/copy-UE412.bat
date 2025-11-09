robocopy C:\Epic\UE_4.12 C:\UEFiles\UE412 *.uasset *.umap /S

cd C:\UEFiles\UE412
dir /b /s *.uasset > UE412_Files.txt
dir /b /s *.umap > UE412_Map_Files.txt

robocopy C:\UEFiles\UE412 C:\UE\AssetTools\AssetTool.Test\InputFiles UE412_Files.txt
robocopy C:\UEFiles\UE412 C:\UE\AssetTools\AssetTool.Test\InputFiles UE412_Map_Files.txt