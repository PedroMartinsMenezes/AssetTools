using System.Diagnostics;
using Xunit.Abstractions;

namespace AssetTool.Test.SucceededTests
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
            Stopwatch w = new Stopwatch();
            var files = File.ReadAllLines("SucceededAssets.txt");
            w.Start();
            for (int i = 0; i < files.Length; i++)
            {
                string file = files[i];
                GlobalNames.Clear();
                AppConfig.AutoCheck = false;
                Log.Enabled = false;
                bool success = StructWriter.RebuildAssetFast(file, "");
                Assert.True(success, $"Failed: [{i}] {file}");
            }
            output.WriteLine($"File Count: {files.Length}");
            output.WriteLine($"End (seconds): {w.Elapsed.TotalSeconds}");
        }
    }
}