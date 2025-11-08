robocopy C:\Epic\UE_4.15 C:\UEFiles\UE415 *.uasset *.umap /S

cd C:\UEFiles\UE415
dir /b /s *.uasset > UE415_Files.txt
dir /b /s *.umap > UE415_Map_Files.txt

robocopy C:\UEFiles\UE415 C:\UE\AssetTools\AssetTool.Test\InputFiles UE415_Files.txt
robocopy C:\UEFiles\UE415 C:\UE\AssetTools\AssetTool.Test\InputFiles UE415_Map_Files.txt