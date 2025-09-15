using NUnit.Framework;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace AssetTool.Test
{
    public class TestBase
    {
        static bool initialized = false;

        public TestBase()
        {
            var cultureInfo = CultureInfo.InvariantCulture;
            CultureInfo.DefaultThreadCurrentCulture = cultureInfo;
            CultureInfo.DefaultThreadCurrentUICulture = cultureInfo;

            if (!initialized)
            {
                initialized = true;
                Directory.SetCurrentDirectory("..\\..\\..\\..\\");
            }
        }

        [TearDown]
        public void TearDown()
        {
            TestContext.WriteLine($"Test Finished: {DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}");
        }

        protected async Task Test_UE_Files(string name, bool saveFiles = false)
        {
            ConcurrentBag<string> failedFiles = new();
            ConcurrentBag<string> succeededFiles = new();
            Stopwatch w = new Stopwatch();
            var files = File.ReadAllLines($"{name}.txt");
            w.Start();
            await Parallel.ForEachAsync(files, async (file, ct) =>
            {
                bool success = await StructWriter.RebuildAssetFastAsync(file, "");
                UpdateFailedFiles(success, file, failedFiles, succeededFiles);
            });
            w.Stop();
            if (saveFiles)
            {
                SaveFiles(name, files, failedFiles, succeededFiles);
            }
            TestContext.WriteLine($"File         : {name}.txt");
            TestContext.WriteLine($"File Count   : {files.Length}");
            TestContext.WriteLine($"Total Seconds: {w.Elapsed.TotalSeconds:0.00}");
        }

        private void UpdateFailedFiles(bool success, string file, ConcurrentBag<string> failedFiles, ConcurrentBag<string> succeededFiles)
        {
            if (!success)
            {
                failedFiles.Add(file);
            }
            else
            {
                succeededFiles.Add(file);
            }
        }

        private void SaveFiles(string name, string[] allFiles, ConcurrentBag<string> failedFiles, ConcurrentBag<string> succeededFiles)
        {
            HashSet<string> failedHashset = failedFiles.ToHashSet();
            failedFiles.Clear();

            HashSet<string> succeededHashset = succeededFiles.ToHashSet();
            succeededFiles.Clear();

            List<string> succeededFilesSorted = [];
            List<string> failedFilesSorted = [];

            foreach (string file in allFiles)
            {
                if (failedHashset.Contains(file))
                {
                    failedFilesSorted.Add(file);
                }
                else if (succeededHashset.Contains(file))
                {
                    succeededFilesSorted.Add(file);
                }
            }

            if (failedFilesSorted.Count > 0)
            {
                UpdateLaunchSettingts(failedFilesSorted.First(), false);
            }

            File.WriteAllLines($"{name}_Failed.txt", failedFilesSorted);
            File.WriteAllLines($"{name}_Succeeded.txt", succeededFilesSorted);
        }

        private static void UpdateLaunchSettingts(string file, bool success)
        {
            if (!success)
            {
                string path = "AssetTool\\Properties\\launchSettings.json";
                string[] lines = File.ReadAllLines(path);
                lines[5] = $"      \"commandLineArgs\": \"{file.Replace('\\', '/')} -log\"";
                File.WriteAllLines(path, lines);
            }
        }
    }
}