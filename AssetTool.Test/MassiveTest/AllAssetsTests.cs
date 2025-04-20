using NUnit.Framework;
using System.IO;

namespace AssetTool.Test.AllTests
{
    public class AllAssetsTests : TestBase
    {
        [Test]
        public void TestAll53()
        {
            var files = File.ReadAllLines("InputAssets.txt");
            for (int i = 11642; i < files.Length; i++)
            {
                string file = files[i];
                AppConfig.AutoCheck = false;
                Log.Enabled = false;

                bool success = StructWriter.RebuildAssetFast(file, "");
                Assert.That(success, $"Failed: [{i}] {file}");
            }
        }

        [Test]
        public void TestAll55()
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
                AppConfig.AutoCheck = false;
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
                //Assert.That(success, $"Failed: [{i}] {file}");
            }
        }

        //[Test]
        //public async System.Threading.Tasks.Task TestAll()
        //{
        //    Stopwatch w = new Stopwatch();
        //    var files = File.ReadAllLines("InputAssets.txt");
        //    w.Start();
        //    await System.Threading.Tasks.Parallel.ForEachAsync(files, async (file, token) =>
        //    {
        //        AppConfig.AutoCheck = false;
        //        Log.Enabled = false;
        //        bool success = await StructWriter.RebuildAssetFastAsync(file, "");
        //        Assert.That(success, file);
        //    });
        //    TestContext.WriteLine($"File Count: {files.Length}");
        //    TestContext.WriteLine($"End (seconds): {w.Elapsed.TotalSeconds,2}");
        //}
    }
}