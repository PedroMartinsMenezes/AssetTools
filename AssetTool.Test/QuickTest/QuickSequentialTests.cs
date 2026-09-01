using NUnit.Framework;
using System.IO;
using System.Reflection;

namespace AssetTool.Test.QuickTest
{
    [NonParallelizable]
    public class QuickSequentialTests : TestBase
    {
        [SetUp]
        public void Setup()
        {
            AppConfig.DebugSaveUnitTest = true;
        }

        [Test]
        [Order(1)]
        public void Test_01_RunUassetToJson()
        {
            var dir = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            bool success = AssetConverter.RunUassetToJsonFiles($"{dir}\\..\\..\\..\\..\\Data\\Input", $"{dir}\\..\\..\\..\\..\\Data\\Output", true);
            Assert.That(success, "RunUassetToJsonFiles failed");
        }

        [Test]
        [Order(2)]
        public void Test_02_RunJsonToUasset()
        {
            var dir = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            bool success = AssetConverter.RunJsonToUassetFiles($"{dir}\\..\\..\\..\\..\\Data\\Output", $"{dir}\\..\\..\\..\\..\\Data\\Input", true);
            Assert.That(success, "RunJsonToUassetFiles failed");
        }

        [Test]
        [Order(3)]
        public void Test_03_QuickTest_Files()
        {
            Test_UE_Files("QuickTest_Files");
        }
    }
}