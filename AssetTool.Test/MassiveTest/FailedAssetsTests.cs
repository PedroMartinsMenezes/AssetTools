using NUnit.Framework;
using System.IO;

namespace AssetTool.Test.FailedTests
{
    public class FailedAssetsTests : TestBase
    {
        //private readonly ITestOutputHelper output;

        //public FailedAssetsTests(ITestOutputHelper output)
        //{
        //    this.output = output;
        //}

        [Test]
        public void TestFailedAssets()
        {
            //output.WriteLine($"Begin: {DateTime.Now:HH:mm:ss}");
            var files = File.ReadAllLines("FailedAssets.txt");
            for (int i = 0; i < files.Length; i++)
            {
                string file = files[i];
                //GlobalNames.Clear();
                AppConfig.DebugCheckMember = false;
                Log.Enabled = false;

                bool success = StructWriter.RebuildAssetFast(file, "");
                if (!success)
                {
                    //output.WriteLine($"Failed: [{i + 1,4}] {file}");
                }
                Assert.That(success);
            }
            //output.WriteLine($"File Count: {files.Length}");
            //output.WriteLine($"End: {DateTime.Now:HH:mm:ss}");
        }
    }
}