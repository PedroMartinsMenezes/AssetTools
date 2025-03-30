using NUnit.Framework;
using System.IO;

namespace AssetTool.Test.SucceededTests
{
    public class SucceededAssetsTests : TestBase
    {
        //private readonly ITestOutputHelper output;

        //public SucceededAssetsTests(ITestOutputHelper output)
        //{
        //    this.output = output;
        //}

        [Test]
        public void TestSucceeded()
        {
            //output.WriteLine($"Begin: {DateTime.Now:HH:mm:ss}");
            var files = File.ReadAllLines("SucceededAssets.txt");
            //Parallel.ForEach(files, (file) =>
            for (int i = 0; i < files.Length; i++)
            {
                string file = files[i];
                //GlobalNames.Clear();
                AppConfig.AutoCheck = false;
                Log.Enabled = false;

                bool success = StructWriter.RebuildAssetFast(file, "");
                if (!success)
                {
                    //output.WriteLine($"Failed: [i] {file}");
                }
                Assert.That(success);
            }
            //output.WriteLine($"End: {DateTime.Now:HH:mm:ss}");
        }
    }
}