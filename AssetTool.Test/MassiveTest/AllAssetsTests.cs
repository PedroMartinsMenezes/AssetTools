using NUnit.Framework;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;

namespace AssetTool.Test.AllTests
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
                AppConfig.DebugCheckMember = false;
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
                //if (i % 10 == 0)
                //{
                //    System.Diagnostics.Debug.WriteLine($"{i} / {files.Length}: Failed: {failedFiles.Count}");
                //}
                string file = files[i];
                AppConfig.DebugCheckMember = false;
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
        public async System.Threading.Tasks.Task Test_UE55_Assets_Succeeded()
        {
            Stopwatch w = new Stopwatch();
            var files = File.ReadAllLines("UE55AssetsSucceeded.txt");
            w.Start();
            int i = 0;
            await System.Threading.Tasks.Parallel.ForEachAsync(files, async (file, ct) =>
            //foreach (string file in files)
            {
                AppConfig.DebugSaveHeader = false;
                AppConfig.DebugSaveReconstructed = false;
                AppConfig.DebugSaveUnitTest = false;
                AppConfig.DebugSaveMember = false;
                AppConfig.DebugCheckMember = false;
                Log.Enabled = false;
                bool success = await StructWriter.RebuildAssetFastAsync(file, "");
                Assert.That(success, $"[{i++}] {file}");
            });
            //}
            w.Stop();
            TestContext.WriteLine($"File Count   : {files.Length}");
            TestContext.WriteLine($"Total Seconds: {w.Elapsed.TotalSeconds:0.00}");
        }
    }
}