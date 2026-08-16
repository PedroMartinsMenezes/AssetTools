using NUnit.Framework;
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
        public void Test_02_RunUassetToJson()
        {
            var dir = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            bool success = StructWriter.RunUassetToJsonFiles($"{dir}\\..\\..\\..\\..\\Data\\Input", $"{dir}\\..\\..\\..\\..\\Data\\Output", true);
            Assert.That(success, "RunUassetToJsonFiles failed");
        }

        [Test]
        [Order(3)]
        public void Test_03_RunJsonToUasset()
        {
            var dir = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            bool success = StructWriter.RunJsonToUassetFiles($"{dir}\\..\\..\\..\\..\\Data\\Output", $"{dir}\\..\\..\\..\\..\\Data\\Input", true);
            Assert.That(success, "RunJsonToUassetFiles failed");
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