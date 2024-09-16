namespace AssetTool
{
    public static class Program
    {
        static void Main(string[] args)
        {
            if (args.Contains("InputAssets.txt"))
            {
                File.WriteAllText("SucceededAssets.txt", "");
                File.WriteAllText("FailedAssets.txt", "");

                var files = File.ReadAllLines("InputAssets.txt");
                for (int i = 0; i < files.Length; i++)
                {
                    string file = files[i];
                    GlobalNames.Clear();
                    AppConfig.AutoCheck = false;
                    Log.Enabled = false;

                    bool success = StructWriter.RebuildAssetFast(file, "C:/Temp/InputAssets/");

                    Log.Enabled = true;
                    string status = success ? "OK  " : "FAIL";
                    Log.Info($"[{i + 1,6}][{status}] {file}");

                    File.AppendAllText(success ? "SucceededAssets.txt" : "FailedAssets.txt", file + Environment.NewLine);
                }
            }
            else
            {
                bool success = StructWriter.RebuildAsset("BP_ThirdPersonCharacter");
                Console.WriteLine(success ? "\nSUCCESS\n" : "\nFAIL\n");
            }
        }
    }
}