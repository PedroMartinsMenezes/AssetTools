using NUnit.Framework;

namespace AssetTool.Test.QuickTest
{
    public class QuickBlueprintTests : TestBase
    {
        [SetUp]
        public void Setup()
        {
            AppConfig.DebugSaveUnitTest = true;
        }

        [Test]
        public void Test_01_Blueprints_UE4()
        {
            Test_UE_Files("Blueprint_Files_UE4");
        }

        [Test]
        public void Test_02_Blueprints_UE5()
        {
            Test_UE_Files("Blueprint_Files_UE5");
        }

        [Test]
        public void Test_03_Blueprints_Others()
        {
            Test_UE_Files("Blueprint_Files_Others");
        }
    }
}