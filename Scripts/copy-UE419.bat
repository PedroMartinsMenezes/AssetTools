robocopy C:\Epic\UE_4.19 C:\UEFiles\UE419 *.uasset *.umap /S

cd C:\UEFiles\UE419
dir /b /s *.uasset > UE419_Files.txt
dir /b /s *.umap > UE419_Map_Files.txt

robocopy C:\UEFiles\UE419 C:\UE\AssetTools\AssetTool.Test\InputFiles UE419_Files.txt
robocopy C:\UEFiles\UE419 C:\UE\AssetTools\AssetTool.Test\InputFiles UE419_Map_Files.txt