using NUnit.Framework;
using System.Diagnostics;
using System.IO;
using System.Reflection;

namespace AssetTool.Test.QuickTest
{
    [NonParallelizable]
    public class QuickTests : TestBase
    {
        [SetUp]
        public void Setup()
        {
            AppConfig.DebugSaveUnitTest = true;
        }

        [Test][Order(1)] public void Test_01_Quick_Files() => Test_UE_Files("QuickTest_Files");

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
            TestContext.Progress.WriteLine($"File Count   : {files.Length}");
            TestContext.Progress.WriteLine($"Total Seconds: {w.Elapsed.TotalSeconds:0.00}");
        }
    }
}