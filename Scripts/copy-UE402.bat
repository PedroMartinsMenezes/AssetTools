robocopy C:\Epic\UE_4.2 C:\UEFiles\UE402 *.uasset *.umap /S

cd C:\UEFiles\UE402
dir /b /s *.uasset > UE402_Files.txt
dir /b /s *.umap > UE402_Map_Files.txt

robocopy C:\UEFiles\UE402 C:\UE\AssetTools\AssetTool.Test\InputFiles UE402_Files.txt
robocopy C:\UEFiles\UE402 C:\UE\AssetTools\AssetTool.Test\InputFiles UE402_Map_Files.txt