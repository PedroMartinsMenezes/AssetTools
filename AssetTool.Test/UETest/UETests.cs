using NUnit.Framework;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace AssetTool.Test.UETests
{
    public class UETests : TestBase
    {
        [Test]
        public async Task Test_01_UE56_Assets()
        {
            Stopwatch w = new Stopwatch();
            var files = File.ReadAllLines("UE56_Files.txt");
            w.Start();
            await Parallel.ForEachAsync(files, async (file, ct) =>
            {
                bool success = await StructWriter.RebuildAssetFastAsync(file, "");
                Assert.That(success, file);
            });
            w.Stop();
            TestContext.WriteLine($"File Count   : {files.Length}");
            TestContext.WriteLine($"Total Seconds: {w.Elapsed.TotalSeconds:0.00}");
        }

        [Test]
        public async Task Test_01_UE56_Maps()
        {
            Stopwatch w = new Stopwatch();
            var files = File.ReadAllLines("UE56_Map_Files.txt");
            w.Start();
            foreach (var file in files)
            {
                bool success = await StructWriter.RebuildAssetFastAsync(file, "");
                Assert.That(success, $"[{files.ToList().IndexOf(file)}] {file}");
            }
            w.Stop();
            TestContext.WriteLine($"File Count   : {files.Length}");
            TestContext.WriteLine($"Total Seconds: {w.Elapsed.TotalSeconds:0.00}");
        }

        [Test]
        public async Task Test_02_UE55_Assets()
        {
            Stopwatch w = new Stopwatch();
            var files = File.ReadAllLines("UE55_Files.txt");
            w.Start();
            await Parallel.ForEachAsync(files, async (file, ct) =>
            {
                bool success = await StructWriter.RebuildAssetFastAsync(file, "");
                Assert.That(success, file);
            });
            w.Stop();
            TestContext.WriteLine($"File Count   : {files.Length}");
            TestContext.WriteLine($"Total Seconds: {w.Elapsed.TotalSeconds:0.00}");
        }

        [Test]
        public async Task Test_02_UE55_Maps()
        {
            Stopwatch w = new Stopwatch();
            var files = File.ReadAllLines("UE55_Map_Files.txt");
            w.Start();
            await Parallel.ForEachAsync(files, async (file, ct) =>
            {
                bool success = await StructWriter.RebuildAssetFastAsync(file, "");
                Assert.That(success, file);
            });
            w.Stop();
            TestContext.WriteLine($"File Count   : {files.Length}");
            TestContext.WriteLine($"Total Seconds: {w.Elapsed.TotalSeconds:0.00}");
        }

        [Test]
        public async Task Test_03_UE54_Assets()
        {
            ConcurrentBag<string> failedFiles = new();
            ConcurrentBag<string> succeededFiles = new();
            Stopwatch w = new Stopwatch();
            var files = File.ReadAllLines("UE54_Files.txt");
            w.Start();
            await Parallel.ForEachAsync(files, async (file, ct) =>
            {
                bool success = await StructWriter.RebuildAssetFastAsync(file, "");
                UpdateFailedFiles(success, file, failedFiles, succeededFiles);
            });
            w.Stop();
            SaveFiles("UE54_Files", files, failedFiles, succeededFiles);
            TestContext.WriteLine($"File Count   : {files.Length}");
            TestContext.WriteLine($"Total Seconds: {w.Elapsed.TotalSeconds:0.00}");
        }

        [Test]
        public async Task Test_03_UE54_Maps()
        {
            ConcurrentBag<string> failedFiles = new();
            ConcurrentBag<string> succeededFiles = new();
            Stopwatch w = new Stopwatch();
            var files = File.ReadAllLines("UE54_Map_Files.txt");
            w.Start();
            await Parallel.ForEachAsync(files, async (file, ct) =>
            {
                bool success = await StructWriter.RebuildAssetFastAsync(file, "");
                UpdateFailedFiles(success, file, failedFiles, succeededFiles);
            });
            w.Stop();
            TestContext.WriteLine($"File Count   : {files.Length}");
            TestContext.WriteLine($"Total Seconds: {w.Elapsed.TotalSeconds:0.00}");
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
    }
}