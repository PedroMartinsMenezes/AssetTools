namespace AssetTool
{
    public static class Program
    {
        static void Main(string[] args)
        {
            string inputFile = null;
            string outputFile = null;
            if (SpecifyUassetToJson(args, ref inputFile, ref outputFile))
            {
                RunUassetToJson(inputFile, outputFile);
            }
            else if (SpecifyJsonToUasset(args, ref inputFile, ref outputFile))
            {
                RunJsonToUasset(inputFile, outputFile);
            }
            else if (args.Length > 0 && args[0].Contains(".uasset"))
            {
                Log.Info(args[0]);
                bool success = StructWriter.RebuildAssetFast(args[0], "");
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

                    bool success = StructWriter.RebuildAssetFast(file, "C:\\Temp\\");

                    Log.Enabled = true;
                    string status = success ? "OK  " : "FAIL";
                    Log.Info($"[{i + 1,6}][{status}] {file}");

                    File.AppendAllText(success ? "SucceededAssets.txt" : "FailedAssets.txt", file + Environment.NewLine);
                }
            }
            else if (args.Length > 0 && args[0].Contains("FailedAssets.txt"))
            {
                IEnumerable<string> allFiles = File.ReadAllLines("FailedAssets.txt");
                IEnumerable<string> firstFiles = allFiles.Take(100);
                IEnumerable<string> lastFiles = allFiles.Skip(100);
                HashSet<string> failed = new HashSet<string>();
                HashSet<string> succeeded = File.ReadAllLines("SucceededAssets.txt").ToHashSet();
                foreach (string file in firstFiles)
                {
                    GlobalNames.Clear();
                    AppConfig.AutoCheck = false;
                    Log.Enabled = false;

                    bool success = StructWriter.RebuildAssetFast(file, "");
                    _ = success ? succeeded.Add(file) : failed.Add(file);

                    Log.Enabled = true;
                    string status = success ? "OK  " : "FAIL";
                    Log.Info($"[{status}] {file}");
                }


                lastFiles = failed.Concat(lastFiles).ToList();

                Log.Info($"\nFailedAssets: Before({allFiles.Count()}) After({lastFiles.Count()})\n");
                File.WriteAllLines("FailedAssets.txt", lastFiles);
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
                bool success = StructWriter.RebuildAssetFast(file, "");
                Log.Info(success ? "\nSUCCESS\n" : "\nFAIL\n");
            }
            else if (args.Length > 0)
            {
                Log.Info(args[0]);
                bool success = StructWriter.RebuildAsset(args[0]);
                Log.Info(success ? "\nSUCCESS\n" : "\nFAIL\n");
            }
            else
            {
                Console.WriteLine("Usage: AssetTool.exe Input.uasset");
                Console.WriteLine("Usage: AssetTool.exe uasset-to-json -i Input.uasset -o Output.json");
            }
        }



        #region uasset-to-json
        private static bool SpecifyUassetToJson(string[] args, ref string inputFile, ref string outputFile)
        {
            bool success = false;
            if (args.FirstOrDefault() != "uasset-to-json")
            {
                return false;
            }
            else if (args.Length < 5)
            {
                success = false;
            }
            else if (args[1] != "-i")
            {
                success = false;
            }
            else if (!File.Exists(args[2]))
            {
                Console.WriteLine($"Input file '{args[2]}' not found.");
                success = false;
            }
            else if (args[3] != "-o")
            {
                success = false;
            }
            else if (!args[4].EndsWith(".json"))
            {
                Console.WriteLine($"Output file '{args[4]}' should be a json file.");
                success = false;
            }
            else
            {
                success = true;
            }

            if (!success)
            {
                Console.WriteLine("Usage: AssetTool.exe uasset-to-json -i Input.uasset -o Output.json");
                return false;
            }
            else
            {
                inputFile = args[2];
                outputFile = args[4];
                return true;
            }
        }

        private static void RunUassetToJson(string inputFile, string outputFile)
        {
            bool success = StructWriter.RunUassetToJson(inputFile, outputFile);
            Console.WriteLine(success ? "\nSUCCESS\n" : "\nFAIL\n");
        }
        #endregion

        #region json-to-uasset
        private static bool SpecifyJsonToUasset(string[] args, ref string inputFile, ref string outputFile)
        {
            bool success = false;
            if (args.FirstOrDefault() != "json-to-uasset")
            {
                return false;
            }
            else if (args.Length < 5)
            {
                success = false;
            }
            else if (args[1] != "-i")
            {
                success = false;
            }
            else if (!File.Exists(args[2]))
            {
                Console.WriteLine($"Input file '{args[2]}' not found.");
                success = false;
            }
            else if (args[3] != "-o")
            {
                success = false;
            }
            else if (!args[2].EndsWith(".json"))
            {
                Console.WriteLine($"Input file '{args[2]}' should be a json file.");
                success = false;
            }
            else
            {
                success = true;
            }

            if (!success)
            {
                Console.WriteLine("Usage: AssetTool.exe json-to-uasset -i Input.json -o Output.uasset");
                return false;
            }
            else
            {
                inputFile = args[2];
                outputFile = args[4];
                return true;
            }
        }

        private static void RunJsonToUasset(string inputFile, string outputFile)
        {
            bool success = StructWriter.RunJsonToUasset(inputFile, outputFile);
            Console.WriteLine(success ? "\nSUCCESS\n" : "\nFAIL\n");
        }
        #endregion
    }
}