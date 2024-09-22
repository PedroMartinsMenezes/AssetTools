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
                IEnumerable<string> list = File.ReadAllLines("FailedAssets.txt").Take(100);
                HashSet<string> failed = new HashSet<string>();
                HashSet<string> succeeded = File.ReadAllLines("SucceededAssets.txt").ToHashSet();
                foreach (string file in list)
                {
                    GlobalNames.Clear();
                    AppConfig.AutoCheck = false;
                    Log.Enabled = false;

                    bool success = StructWriter.RebuildAssetFast(file, "C:/Temp/InputAssets/");
                    _ = success ? succeeded.Add(file) : failed.Add(file);

                    Log.Enabled = true;
                    string status = success ? "OK  " : "FAIL";
                    Log.Info($"[{status}] {file}");
                }
                Log.Info($"\nFailedAssets: Before({list.Count()}) After({failed.Count})\n");
                File.WriteAllLines("FailedAssets.txt", failed);
                File.WriteAllLines("SucceededAssets.txt", succeeded);
            }
            else if (args.Length > 0 && args[0].Contains("FirstFailed"))
            {
                var file = File.ReadAllLines("FailedAssets.txt").FirstOrDefault();
                if (file is null)
                {
                    Log.Info("FailedAssets.txt is empty");
                    return;
                }
                Log.Info(file);
                bool success = StructWriter.RebuildAssetFast(file, "C:/Temp/InputAssets/");
                Log.Info(success ? "\nSUCCESS\n" : "\nFAIL\n");
            }
            else
            {
                Log.Info(args[0]);
                bool success = StructWriter.RebuildAsset(args[0]);
                Log.Info(success ? "\nSUCCESS\n" : "\nFAIL\n");
            }
        }
    }
}