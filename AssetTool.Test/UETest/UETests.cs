using NUnit.Framework;

namespace AssetTool.Test.UETests
{
    public class UETests : TestBase
    {
        [Test] public void Test_01_UE56_Assets() => Test_UE_Files("UE56_Files");
        [Test] public void Test_01_UE56_Maps() => Test_UE_Files("UE56_Map_Files");
        [Test] public void Test_02_UE55_Assets() => Test_UE_Files("UE55_Files");
        [Test] public void Test_02_UE55_Maps() => Test_UE_Files("UE55_Map_Files");
        [Test] public void Test_03_UE54_Assets() => Test_UE_Files("UE54_Files");
        [Test] public void Test_03_UE54_Maps() => Test_UE_Files("UE54_Map_Files");
        [Test] public void Test_04_UE53_Assets() => Test_UE_Files("UE53_Files");
        [Test] public void Test_04_UE53_Maps() => Test_UE_Files("UE53_Map_Files");
        [Test] public void Test_05_UE52_Assets() => Test_UE_Files("UE52_Files");
        [Test] public void Test_05_UE52_Maps() => Test_UE_Files("UE52_Map_Files");
        [Test] public void Test_06_UE51_Assets() => Test_UE_Files("UE51_Files");
        [Test] public void Test_06_UE51_Maps() => Test_UE_Files("UE51_Map_Files");
    }
}