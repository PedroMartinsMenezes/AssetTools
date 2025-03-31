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
            for (int i = 11505; i < files.Length; i++)
            {
                string file = files[i];
                AppConfig.AutoCheck = false;
                Log.Enabled = false;

                bool success = StructWriter.RebuildAssetFast(file, "");
                Assert.That(success, $"Failed: [{i}] {file}");
            }
        }
    }
}