robocopy C:\Epic\UE_4.9 C:\UEFiles\UE409 *.uasset *.umap /S

cd C:\UEFiles\UE409
dir /b /s *.uasset > UE409_Files.txt
dir /b /s *.umap > UE409_Map_Files.txt

robocopy C:\UEFiles\UE409 C:\UE\AssetTools\AssetTool.Test\InputFiles UE409_Files.txt
robocopy C:\UEFiles\UE409 C:\UE\AssetTools\AssetTool.Test\InputFiles UE409_Map_Files.txt