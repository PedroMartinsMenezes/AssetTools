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

        [Test]
        [Order(1)]
        public void Test_01_Quick_Files()
        {
            Test_UE_Files("QuickTest_Files");
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

        [Test]
        [Order(3)]
        public void Test_03_RunUassetToJson()
        {
            string input = "Data\\Input\\BP_TestActor.uasset";
            string output = "Data\\Output\\BP_TestActor.json";
            bool success = StructWriter.RunUassetToJson(input, output);
            Assert.That(success, input);
        }

        [Test]
        [Order(4)]
        public void Test_04_Blueprints_UE4()
        {
            Test_UE_Files("Blueprint_Files_UE4");
        }

        [Test]
        [Order(4)]
        public void Test_05_Blueprints_UE5()
        {
            Test_UE_Files("Blueprint_Files_UE5");
        }

        [Test]
        [Order(4)]
        public void Test_06_Blueprints_Others()
        {
            Test_UE_Files("Blueprint_Files_Others");
        }
    }
}