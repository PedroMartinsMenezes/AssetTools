using NUnit.Framework;

namespace AssetTool.Test.SamplesTest
{
    public class SamplesTests : TestBase
    {
        [SetUp]
        public void Setup()
        {
            AppConfig.DebugSaveUnitTest = true;
        }

        [Test] public void Test_Cropout_Assets() => Test_UE_Files("Cropout_Files");

        [Test] public void Test_StackOBot_Assets() => Test_UE_Files("StackOBot_Files");

        [Test] public void Test_Lyra_Assets() => Test_UE_Files("Lyra_Files");
    }
}