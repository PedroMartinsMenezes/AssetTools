robocopy C:\Epic\UE_4.17 C:\UEFiles\UE417 *.uasset *.umap /S

cd C:\UEFiles\UE417
dir /b /s *.uasset > UE417_Files.txt
dir /b /s *.umap > UE417_Map_Files.txt

robocopy C:\UEFiles\UE417 C:\UE\AssetTools\AssetTool.Test\InputFiles UE417_Files.txt
robocopy C:\UEFiles\UE417 C:\UE\AssetTools\AssetTool.Test\InputFiles UE417_Map_Files.txt