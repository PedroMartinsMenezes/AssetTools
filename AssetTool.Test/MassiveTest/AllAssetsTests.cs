using NUnit.Framework;
using System.IO;

namespace AssetTool.Test.AllTests
{
    public class AllAssetsTests : TestBase
    {
        [Test]
        public void TestAll()
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