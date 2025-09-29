robocopy C:\Epic\UE_4.24 C:\UEFiles\UE424 *.uasset *.umap /S

cd C:\UEFiles\UE424
dir /b /s *.uasset > UE424_Files.txt
dir /b /s *.umap > UE424_Map_Files.txt

robocopy C:\UEFiles\UE424 C:\UE\AssetTools\AssetTool.Test\InputFiles UE424_Files.txt
robocopy C:\UEFiles\UE424 C:\UE\AssetTools\AssetTool.Test\InputFiles UE424_Map_Files.txt