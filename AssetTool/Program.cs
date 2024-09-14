using AssetTool;

bool success = StructWriter.RebuildAsset("CropoutSampleProject/Villagers/BP_Villager");

Console.WriteLine(success ? "\nSUCCESS\n" : "\nFAIL\n");
