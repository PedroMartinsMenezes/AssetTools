using NUnit.Framework;
using System.IO;

namespace AssetTool.Test.SucceededTests
{
    public class SucceededAssetsTests : TestBase
    {
        [Test]
        public async System.Threading.Tasks.Task TestSucceeded()
        {
            var files = File.ReadAllLines("SucceededAssets.txt");
            await System.Threading.Tasks.Parallel.ForEachAsync(files, async (file, token) =>
            {
                AppConfig.AutoCheck = false;
                Log.Enabled = false;
                bool success = await StructWriter.RebuildAssetFastAsync(file, "");
                Assert.That(success, file);
            });
        }
    }
}