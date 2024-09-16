namespace AssetTool
{
    public static class Program
    {
        static void Main(string[] args)
        {
            bool success = StructWriter.RebuildAsset("CropoutSampleProject/Villagers/BPI_Villager");

            Console.WriteLine(success ? "\nSUCCESS\n" : "\nFAIL\n");
        }
    }
}