using NUnit.Framework;
using System.Diagnostics;
using System.IO;
using System.Reflection;
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
        [Order(1)]
        public async Task Test_01_Quick_Files()
        {
            Stopwatch w = new Stopwatch();
            var files = File.ReadAllLines("QuickTest_Files.txt");
            w.Start();
            foreach (var file in files)
            {
                bool success = await StructWriter.RebuildAssetFastAsync(file, "");
                Assert.That(success, file);
            }
            w.Stop();
            TestContext.WriteLine($"File Count   : {files.Length}");
            TestContext.WriteLine($"Total Seconds: {w.Elapsed.TotalSeconds:0.00}");
        }

        [Test]
        [Order(2)]
        public void Test_02_RunJsonToUasset()
        {
            Stopwatch w = new Stopwatch();
            var dir = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            string[] files = Directory.GetFiles($"{dir}\\..\\..\\..\\..\\Data\\Output", "*.json", SearchOption.AllDirectories);
            w.Start();
            foreach (string file in files)
            {
                bool success = StructWriter.RunJsonToUasset(file, null);
                Assert.That(success, file);
            }
            w.Stop();
            TestContext.WriteLine($"File Count   : {files.Length}");
            TestContext.WriteLine($"Total Seconds: {w.Elapsed.TotalSeconds:0.00}");
        }
    }
}