using System.Diagnostics;
using System.Globalization;
using System.Text.Json;

namespace AssetTool
{
    public static class Program
    {
        static Dictionary<string, FileVersion> FileVersions = [];

        static void Main(string[] args)
        {
            Stopwatch stopwatch = Stopwatch.StartNew();
            var cultureInfo = CultureInfo.InvariantCulture;
            CultureInfo.DefaultThreadCurrentCulture = cultureInfo;
            CultureInfo.DefaultThreadCurrentUICulture = cultureInfo;
            Log.Enabled = args.Contains("-log");
            string inputFile = default;
            string outputFile = default;
            string outputDir = default;
            if (SpecifyUassetToJson(args, ref inputFile, ref outputFile))
            {
                RunUassetToJson(inputFile, outputFile);
            }
            else if (SpecifyJsonToUasset(args, ref inputFile, ref outputFile))
            {
                RunJsonToUasset(inputFile, outputFile);
            }
            else if (SpecifyDiff(args, ref inputFile, ref outputDir))
            {
                RunDiff(inputFile, outputDir);
            }
            else if (args.Length > 0 && args[0].Contains("InputAssets.txt"))
            {
                Log.Info($"Command: InputAssets.txt");
                Log.Info($"File   : InputAssets.txt");
                File.WriteAllText("SucceededAssets.txt", "");
                File.WriteAllText("FailedAssets.txt", "");

                var files = File.ReadAllLines("InputAssets.txt");
                for (int i = 0; i < files.Length; i++)
                {
                    string file = files[i];
                    ///GlobalNames.Clear();
                    AppConfig.DebugCheckMember = false;
                    bool enabled = Log.Enabled;

                    bool success = AssetConverter.RebuildAssetFast(file, "C:\\Temp\\", null);

                    Log.Enabled = enabled;
                    string status = success ? "OK  " : "FAIL";
                    Log.Info($"[{i + 1,6}][{status}] {file}");

                    File.AppendAllText(success ? "SucceededAssets.txt" : "FailedAssets.txt", file + Environment.NewLine);
                }
            }
            else if (args.Length > 0 && args[0].Contains("FailedAssets.txt"))
            {
                Log.Info($"Command: FailedAssets.txt");
                Log.Info($"File   : FailedAssets.txt");
                IEnumerable<string> allFiles = File.ReadAllLines("FailedAssets.txt");
                IEnumerable<string> firstFiles = allFiles.Take(100);
                IEnumerable<string> lastFiles = allFiles.Skip(100);
                HashSet<string> failed = new HashSet<string>();
                HashSet<string> succeeded = File.ReadAllLines("SucceededAssets.txt").ToHashSet();
                foreach (string file in firstFiles)
                {
                    ///GlobalNames.Clear();
                    AppConfig.DebugCheckMember = false;
                    bool enabled = Log.Enabled;

                    bool success = AssetConverter.RebuildAssetFast(file, "");
                    _ = success ? succeeded.Add(file) : failed.Add(file);

                    Log.Enabled = enabled;
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
                Log.Info($"Command: FirstFailed");
                Log.Info($"File   : FailedAssets.txt");
                var file = File.ReadAllLines("FailedAssets.txt").FirstOrDefault();
                if (file == default)
                {
                    Log.Info("FailedAssets.txt is empty");
                    return;
                }
                Log.Info(file);
                bool success = AssetConverter.RebuildAssetFast(file, "");
                Log.Info(success ? "\nSUCCESS\n" : "\nFAIL\n");
            }
            else if (args.Length > 1 && args[0].Contains("unit-test"))
            {
                Log.Enabled = args.Contains("-log");
                AppConfig.DebugSaveUnitTest = true;
                Log.Info($"Command: unit-test");
                Log.Info($"File   : {args[1]}");
                bool success = AssetConverter.RebuildAssetFast(args[1], "");
                Log.Info(success ? "\nSUCCESS\n" : "\nFAIL\n");
            }
            else if (args.Length > 2 && args[0].Contains("check-type"))
            {
                Log.Info($"Command: check-type");
                Log.Info($"File   : {args[1]}");
                Log.Info($"Type   : {args[2]}");
                Console.WriteLine(AssetConverter.IsAssetType(args[1], args[2]));
            }
            else if (args.Length > 1 && args[0].Contains("get-type"))
            {
                Log.Info($"Command: get-type");
                Log.Info($"File   : {args[1]}");
                Log.Enabled = false;
                Console.WriteLine(AssetConverter.GetAssetType(args[1]));
            }
            else if (args.Length > 0)
            {
                string file = args[0];
                Log.Info($"Command: rebuild-asset");
                Log.Info($"File   : {file}");
                FileVersion fileVersion = GetFileVersion(args);
                bool success = AssetConverter.RebuildAssetFast(file, fileVersion: fileVersion);
                Log.Enabled = true;
                Log.Info(success ? "\nSUCCESS\n" : "\nFAIL\n");
            }
            else
            {
                Console.WriteLine("Usage: AssetTool.exe Input.uasset");
                Console.WriteLine("Usage: AssetTool.exe uasset-to-json -i Input.uasset -o Output.json");
            }

            Console.WriteLine($"Total Time(s): {Math.Round(stopwatch.Elapsed.TotalSeconds, 2)}");
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
                Console.WriteLine("Command: uasset-to-json");
                Console.WriteLine($"Input : {inputFile}");
                Console.WriteLine($"Output: {outputFile}");
                return true;
            }
        }

        private static void RunUassetToJson(string inputFile, string outputFile)
        {
            bool success = AssetConverter.RunUassetToJson(inputFile, outputFile);
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
                Console.WriteLine("Command: json-to-uasset");
                Console.WriteLine($"Input : {inputFile}");
                Console.WriteLine($"Output: {outputFile}");
                return true;
            }
        }

        private static void RunJsonToUasset(string inputFile, string outputFile)
        {
            bool success = AssetConverter.RunJsonToUasset(inputFile, outputFile);
            Console.WriteLine(success ? "\nSUCCESS\n" : "\nFAIL\n");
        }
        #endregion

        #region diff
        private static bool SpecifyDiff(string[] args, ref string inputFile, ref string outputDir)
        {
            bool success = false;
            if (args.FirstOrDefault() != "diff")
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
            else
            {
                success = true;
            }

            if (!success)
            {
                Console.WriteLine("Usage: AssetTool.exe diff -i Input.uasset -o Output.json");
                return false;
            }
            else
            {
                inputFile = args[2];
                outputDir = args[4];
                Console.WriteLine("Command: diff");
                Console.WriteLine($"Input : {inputFile}");
                Console.WriteLine($"Output: {outputDir}");
                return true;
            }
        }

        private static void RunDiff(string inputFile, string outputDir)
        {
            outputDir = string.IsNullOrEmpty(Path.GetDirectoryName(outputDir)) ? Directory.GetCurrentDirectory() : Path.GetDirectoryName(outputDir);
            string inputDir = string.IsNullOrEmpty(Path.GetDirectoryName(inputFile)) ? Directory.GetCurrentDirectory() : Path.GetDirectoryName(inputFile);
            string ext = Path.GetExtension(inputFile);
            string inputFile1 = Path.Combine(outputDir, Path.GetFileNameWithoutExtension(inputFile) + ".prev" + ext);
            string inputFile2 = inputFile;
            string outputFile1 = Path.Combine(outputDir, Path.GetFileNameWithoutExtension(inputFile) + ".prev.json");
            string outputFile2 = Path.Combine(outputDir, Path.GetFileNameWithoutExtension(inputFile) + ".json");

            Console.WriteLine("\nGetting the previous file in git...");
            if (!ExecuteGitCommand("git", $"show HEAD:./{Path.GetFileName(inputFile)}", inputDir, inputFile1))
            {
                Console.WriteLine("\nFAIL\n");
                return;
            }

            Console.WriteLine($"\nProcessing previous file: {inputFile1}");
            if (!AssetConverter.RunUassetToJson(inputFile1, outputFile1))
            {
                Console.WriteLine("\nFAIL\n");
                return;
            }

            ///GlobalNames.Clear();

            Console.WriteLine($"\nProcessing current file: {inputFile2}");
            if (!AssetConverter.RunUassetToJson(inputFile2, outputFile2))
            {
                Console.WriteLine("\nFAIL\n");
                return;
            }

            Log.Info("\nSUCCESS\n");
        }

        static bool ExecuteGitCommand(string command, string arguments, string workingDirectory, string outputPath)
        {
            try
            {
                ProcessStartInfo startInfo = new ProcessStartInfo
                {
                    FileName = command,
                    Arguments = arguments,
                    RedirectStandardOutput = true,
                    UseShellExecute = false,
                    CreateNoWindow = true,
                    StandardOutputEncoding = default,
                    RedirectStandardError = true,
                    WorkingDirectory = workingDirectory
                };
                using (Process process = Process.Start(startInfo))
                {
                    using (Stream output = process.StandardOutput.BaseStream)
                    using (FileStream fileStream = new FileStream(outputPath, FileMode.Create, FileAccess.Write))
                    {
                        output.CopyTo(fileStream);
                    }
                    string error = process.StandardError.ReadToEnd();
                    if (!string.IsNullOrEmpty(error))
                    {
                        Console.WriteLine("Error calling git command: " + error);
                        return false;
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error calling git command: " + ex.Message);
                return false;
            }
        }
        #endregion

        #region File Versions
        private static FileVersion GetFileVersion(string[] args)
        {
            if (!args.Contains("-v"))
                return null;

            LoadFileVersions();

            int index = Array.IndexOf(args, "-v");
            string version = args[index + 1];

            if (FileVersions.TryGetValue(version, out FileVersion fileVersion))
            {
                return fileVersion;
            }
            else
            {
                Console.WriteLine($"File version '{version}' not found.");
                return null;
            }
        }

        public static void LoadFileVersions()
        {
            foreach (string path in Directory.GetFiles("Data/CustomVersions", "*.json"))
            {
                string name = Path.GetFileNameWithoutExtension(path);
                string json = File.ReadAllText(path);
                var fileVersion = JsonSerializer.Deserialize<FileVersion>(json);
                FileVersions[name] = fileVersion;
            }
        }
        #endregion
    }
}