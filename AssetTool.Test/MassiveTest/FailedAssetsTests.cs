using Xunit.Abstractions;

namespace AssetTool.Test.MassiveTest
{
    [Collection("Sequential")]
    public class FailedAssetsTests : TestBase
    {
        private readonly ITestOutputHelper output;

        public FailedAssetsTests(ITestOutputHelper output)
        {
            this.output = output;
        }

        [Fact]
        public void TestFailedAssets()
        {
            output.WriteLine($"Begin: {DateTime.Now:HH:mm:ss}");
            var files = File.ReadAllLines("FailedAssets.txt");
            for (int i = 23; i < files.Length; i++)
            {
                string file = files[i];
                GlobalNames.Clear();
                AppConfig.AutoCheck = false;
                Log.Enabled = false;

                bool success = StructWriter.RebuildAssetFast(file, "");
                if (!success)
                {
                    output.WriteLine($"Failed: [{i,4}] {file}");
                }
                Assert.True(success);
            }
            output.WriteLine($"File Count: {files.Length}");
            output.WriteLine($"End: {DateTime.Now:HH:mm:ss}");
        }
    }
}