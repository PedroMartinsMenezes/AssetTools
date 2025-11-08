robocopy C:\Epic\UE_4.16 C:\UEFiles\UE416 *.uasset *.umap /S

cd C:\UEFiles\UE416
dir /b /s *.uasset > UE416_Files.txt
dir /b /s *.umap > UE416_Map_Files.txt

robocopy C:\UEFiles\UE416 C:\UE\AssetTools\AssetTool.Test\InputFiles UE416_Files.txt
robocopy C:\UEFiles\UE416 C:\UE\AssetTools\AssetTool.Test\InputFiles UE416_Map_Files.txt