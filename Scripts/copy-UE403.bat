robocopy C:\Epic\UE_4.3 C:\UEFiles\UE403 *.uasset *.umap /S

cd C:\UEFiles\UE403
dir /b /s *.uasset > UE403_Files.txt
dir /b /s *.umap > UE403_Map_Files.txt

robocopy C:\UEFiles\UE403 C:\UE\AssetTools\AssetTool.Test\InputFiles UE403_Files.txt
robocopy C:\UEFiles\UE403 C:\UE\AssetTools\AssetTool.Test\InputFiles UE403_Map_Files.txt