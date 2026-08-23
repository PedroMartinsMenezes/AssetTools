using NUnit.Framework;

namespace AssetTool.Test.CookedTest
{
    public class StackOBotCookedTests : TestBase
    {
        [Test] public void Test_Cooked_StackOBot() => Test_UE_Files_Sequential("StackOBot_Cooked_Files");
    }
}