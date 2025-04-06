using NUnit.Framework;
using System.Diagnostics;
using System.IO;

namespace AssetTool.Test.SucceededTests
{
    public class SucceededAssetsTests : TestBase
    {
        [Test]
        public async System.Threading.Tasks.Task TestSucceeded()
        {
            Stopwatch w = new Stopwatch();
            var files = File.ReadAllLines("SucceededAssets.txt");
            w.Start();
            await System.Threading.Tasks.Parallel.ForEachAsync(files, async (file, token) =>
            {
                AppConfig.AutoCheck = false;
                Log.Enabled = false;
                bool success = await StructWriter.RebuildAssetFastAsync(file, "");
                Assert.That(success, file);
            });
            w.Stop();
            TestContext.WriteLine($"File Count: {files.Length}");
            TestContext.WriteLine($"End (seconds): {w.Elapsed.TotalSeconds,2}");
        }
    }
}