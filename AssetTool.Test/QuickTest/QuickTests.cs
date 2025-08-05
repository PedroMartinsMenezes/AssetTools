using NUnit.Framework;
using System.Diagnostics;
using System.IO;
using System.Threading.Tasks;

namespace AssetTool.Test.QuickTest
{
    public class QuickTests : TestBase
    {
        [SetUp]
        public void Setup()
        {
            AppConfig.DebugSaveUnitTest = true;
        }

        [Test]
        public async Task Test_Quick()
        {
            Stopwatch w = new Stopwatch();
            var files = File.ReadAllLines("QuickTest_Files.txt");
            w.Start();
            for (int i = 0; i < files.Length; i++)
            {
                var file = files[i];
                bool success = await StructWriter.RebuildAssetFastAsync(file, "");
                Assert.That(success, $"[{i++}] {file}");
            }
            w.Stop();
            TestContext.WriteLine($"File Count   : {files.Length}");
            TestContext.WriteLine($"Total Seconds: {w.Elapsed.TotalSeconds:0.00}");
            TestContext.WriteLine($"File Count   : {files.Length}");
        }
    }
}