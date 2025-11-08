robocopy C:\Epic\UE_4.14 C:\UEFiles\UE414 *.uasset *.umap /S

cd C:\UEFiles\UE414
dir /b /s *.uasset > UE414_Files.txt
dir /b /s *.umap > UE414_Map_Files.txt

robocopy C:\UEFiles\UE414 C:\UE\AssetTools\AssetTool.Test\InputFiles UE414_Files.txt
robocopy C:\UEFiles\UE414 C:\UE\AssetTools\AssetTool.Test\InputFiles UE414_Map_Files.txt