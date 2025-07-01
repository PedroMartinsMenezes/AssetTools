using NUnit.Framework;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;

namespace AssetTool.Test.MassiveTest
{
    public class AllAssetsTests : TestBase
    {
        [Test]
        public void Test_UE55_Assets_All()
        {
            File.WriteAllText("UE55AssetsFailed.txt", "");
            File.WriteAllText("UE55AssetsSucceeded.txt", "");
            var files = File.ReadAllLines("UE55Assets.txt");
            for (int i = 0; i < files.Length; i++)
            {
                if (i % 100 == 0)
                {
                    System.Diagnostics.Debug.WriteLine(i);
                }
                string file = files[i];
                Log.Enabled = false;
                bool success = StructWriter.RebuildAssetFast(file, "");
                if (success)
                {
                    File.AppendAllText("UE55AssetsSucceeded.txt", $"{file}\n");
                }
                else
                {
                    File.AppendAllText("UE55AssetsFailed.txt", $"{file}\n");
                }
            }
        }

        [Test]
        public void Test_UE55_Assets_Failed()
        {
            var failedFiles = new List<string>();
            var succeededFiles = new List<string>();
            var files = File.ReadAllLines("UE55AssetsFailed.txt");
            for (int i = 0; i < files.Length; i++)
            {
                string file = files[i];
                Log.Enabled = false;
                bool success = StructWriter.RebuildAssetFast(file, "");
                if (success)
                {
                    succeededFiles.Add(file);
                }
                else
                {
                    failedFiles.Add(file);
                }
            }
            File.AppendAllLines("UE55AssetsSucceeded.txt", succeededFiles);
            File.WriteAllLines("UE55AssetsFailed.txt", failedFiles);
        }

        [Test]
        public void Test_UE55_Assets_Succeeded()
        {
            Stopwatch w = new Stopwatch();
            var files = File.ReadAllLines("UE55AssetsSucceeded.txt");
            w.Start();
            int i = 0;
            string currentFile = default;
            try
            {
                System.Threading.Tasks.Parallel.ForEach(files, (file) =>
                //foreach (string file in files)
                {
                    currentFile = file;
                    bool success = StructWriter.RebuildAssetFast(file, "");
                    Assert.That(success, $"[{i++}] {file}");
                    //}
                });
            }
            catch (System.Exception ex)
            {
                TestContext.WriteLine($"Error: {ex.Message}\n{currentFile}");
                throw;
            }
            w.Stop();
            TestContext.WriteLine($"File Count   : {files.Length}");
            TestContext.WriteLine($"Total Seconds: {w.Elapsed.TotalSeconds:0.00}");
        }
    }
}