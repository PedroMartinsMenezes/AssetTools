robocopy C:\Epic\UE_4.6 C:\UEFiles\UE406 *.uasset *.umap /S

cd C:\UEFiles\UE406
dir /b /s *.uasset > UE406_Files.txt
dir /b /s *.umap > UE406_Map_Files.txt

robocopy C:\UEFiles\UE406 C:\UE\AssetTools\AssetTool.Test\InputFiles UE406_Files.txt
robocopy C:\UEFiles\UE406 C:\UE\AssetTools\AssetTool.Test\InputFiles UE406_Map_Files.txt