using NUnit.Framework;
using System.IO;

namespace AssetTool.Test.AllTests
{
    public class AllAssetsTests : TestBase
    {
        //private readonly ITestOutputHelper output;

        //public AllAssetsTests(ITestOutputHelper output)
        //{
        //    this.output = output;
        //}

        [Test]
        public void TestAll()
        {
            //output.WriteLine($"Begin: {DateTime.Now:HH:mm:ss}");
            var files = File.ReadAllLines("InputAssets.txt");
            for (int i = 11505; i < files.Length; i++)
            {
                string file = files[i];
                //GlobalNames.Clear();
                AppConfig.AutoCheck = false;
                Log.Enabled = false;

                bool success = StructWriter.RebuildAssetFast(file, "");
                if (!success)
                {
                    //output.WriteLine($"Failed: [{i}] {file}");
                }
                Assert.That(success);
            }
            //output.WriteLine($"File Count: {files.Length}");
            //output.WriteLine($"End: {DateTime.Now:HH:mm:ss}");
        }
    }
}