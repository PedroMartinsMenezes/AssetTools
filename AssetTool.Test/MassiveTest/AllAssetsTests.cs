using Xunit.Abstractions;

namespace AssetTool.Test.AllTests
{
    [Collection("Sequential")]
    public class AllAssetsTests : TestBase
    {
        private readonly ITestOutputHelper output;

        public AllAssetsTests(ITestOutputHelper output)
        {
            this.output = output;
        }

        [Fact]
        public void TestAll()
        {
            output.WriteLine($"Begin: {DateTime.Now:HH:mm:ss}");
            var files = File.ReadAllLines("InputAssets.txt");
            for (int i = 11505; i < files.Length; i++)
            {
                string file = files[i];
                GlobalNames.Clear();
                AppConfig.AutoCheck = false;
                Log.Enabled = false;

                bool success = StructWriter.RebuildAssetFast(file, "");
                if (!success)
                {
                    output.WriteLine($"Failed: [{i}] {file}");
                }
                Assert.True(success);
            }
            output.WriteLine($"File Count: {files.Length}");
            output.WriteLine($"End: {DateTime.Now:HH:mm:ss}");
        }
    }
}