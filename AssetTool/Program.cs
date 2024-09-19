namespace AssetTool
{
    public static class Program
    {
        static void Main(string[] args)
        {
            if (args.Length > 0 && args[0].Contains(".uasset"))
            {
                Log.Info(args[0]);
                bool success = StructWriter.RebuildAssetFast(args[0], "C:/Temp/InputAssets/");
                Log.Info(success ? "\nSUCCESS\n" : "\nFAIL\n");
                return;
            }
            else if (args.Length > 0 && args[0].Contains("InputAssets.txt"))
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
            else if (args.Length > 0 && args[0].Contains("FailedAssets.txt"))
            {
                var files = File.ReadAllLines("FailedAssets.txt");
                var newFiles = new List<string>();
                for (int i = 0; i < Math.Min(100, files.Length); i++)
                {
                    string file = files[i];
                    GlobalNames.Clear();
                    AppConfig.AutoCheck = false;
                    Log.Enabled = false;

                    bool success = StructWriter.RebuildAssetFast(file, "C:/Temp/InputAssets/");

                    if (!success) newFiles.Add(file);
                    Log.Enabled = true;
                    string status = success ? "OK  " : "FAIL";
                    Log.Info($"[{i + 1,6}][{status}] {file}");
                }
                File.WriteAllLines("FailedAssets.txt", newFiles);
            }
        }
    }
}