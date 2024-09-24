using Xunit.Abstractions;

namespace AssetTool.Test
{
    [Collection("Sequential")]
    public class SucceededAssetsTests : TestBase
    {
        private readonly ITestOutputHelper output;

        public SucceededAssetsTests(ITestOutputHelper output)
        {
            this.output = output;
        }

        [Fact]
        public void TestSucceeded()
        {
            var files = File.ReadAllLines("SucceededAssets.txt");
            for (int i = 0; i < files.Length; i++)
            {
                string file = files[i];
                GlobalNames.Clear();
                AppConfig.AutoCheck = false;
                Log.Enabled = false;

                bool success = StructWriter.RebuildAssetFast(file, "C:/Temp/");
                if (!success)
                {
                    output.WriteLine($"Failed: {file}");
                }
                Assert.True(success);
            }
            output.WriteLine($"File Count: {files.Length}");
        }
    }
}