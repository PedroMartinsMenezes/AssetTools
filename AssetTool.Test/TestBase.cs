using NUnit.Framework;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;

namespace AssetTool.Test
{
    public class TestBase
    {
        private Stopwatch stopwatch = new Stopwatch();
        protected static Dictionary<string, FileVersion> FileVersions = [];

        public TestBase()
        {
            var cultureInfo = CultureInfo.InvariantCulture;
            CultureInfo.DefaultThreadCurrentCulture = cultureInfo;
            CultureInfo.DefaultThreadCurrentUICulture = cultureInfo;
        }

        static TestBase()
        {
            Directory.SetCurrentDirectory("..\\..\\..\\..\\");

            foreach (string path in Directory.GetFiles("Data/CustomVersions", "*.json"))
            {
                string name = Path.GetFileNameWithoutExtension(path);
                string json = File.ReadAllText(path);
                var fileVersion = JsonSerializer.Deserialize<FileVersion>(json);
                FileVersions[name] = fileVersion;
            }
        }

        protected bool IsVs2026()
        {
            string vsEnv = Environment.GetEnvironmentVariable("VisualStudioVersion");
            return !string.IsNullOrEmpty(vsEnv) && vsEnv.Contains("18");
        }

        [TearDown]
        public virtual void TearDown()
        {
            TestContext.WriteLine($"Test Finished: {DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}");
        }

        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            var culture = CultureInfo.InvariantCulture;
            Thread.CurrentThread.CurrentCulture = culture;
            Thread.CurrentThread.CurrentUICulture = culture;
            stopwatch.Start();
        }

        [OneTimeTearDown]
        public void GlobalTeardown()
        {
            TestContext.Progress.WriteLine($"->\n-> [{TestContext.CurrentContext.Test.Name}] Total Time(s): {Math.Round(stopwatch.Elapsed.TotalSeconds, 2)}\n->");
        }

        protected void Test_UE_Files(string name)
        {
            ConcurrentBag<string> failedFiles = new();
            ConcurrentBag<string> succeededFiles = new();
            Stopwatch w = new Stopwatch();
            var files = File.ReadAllLines($"AssetTool.Test\\InputFiles\\{name}.txt");
            w.Start();
            Parallel.ForEach(files, file =>
            {
                bool success = AssetConverter.RebuildAssetFast(file, "");
                if (!AppConfig.ContinueAfterError)
                {
                    Assert.That(success, file);
                }
                UpdateFailedFiles(success, file, failedFiles, succeededFiles);
            });
            w.Stop();
            TestContext.WriteLine($"Test         : {TestContext.CurrentContext.Test.Name}");
            TestContext.WriteLine($"Scenario     : {name}.txt");
            TestContext.WriteLine($"File Count   : {files.Length}");
            TestContext.WriteLine($"Total Seconds: {w.Elapsed.TotalSeconds:0.00}");
        }

        protected void Test_UE_Files_Sequential(string name, bool saveFiles = false)
        {
            ConcurrentBag<string> failedFiles = new();
            ConcurrentBag<string> succeededFiles = new();
            Stopwatch w = new Stopwatch();
            var files = File.ReadAllLines($"AssetTool.Test\\InputFiles\\{name}.txt");
            w.Start();
            for (int i = 0; i < files.Length; i++)
            {
                string file = files[i];
                bool success = AssetConverter.RebuildAssetFast(file, "");
                UpdateFailedFiles(success, file, failedFiles, succeededFiles);
                if (!AppConfig.ContinueAfterError && !success)
                {
                    TestContext.WriteLine($"File {i + 1,-8}: {file}");
                    break;
                }
            }
            w.Stop();
            if (saveFiles)
            {
                SaveFiles(name, files, failedFiles, succeededFiles);
            }
            TestContext.WriteLine($"Scenario     : {name}.txt");
            TestContext.WriteLine($"File Count   : {files.Length}");
            TestContext.WriteLine($"Total Seconds: {w.Elapsed.TotalSeconds:0.00}");
            Assert.That(failedFiles.Count == 0);
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
            HashSet<string> succeededHashset = succeededFiles.ToHashSet();
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