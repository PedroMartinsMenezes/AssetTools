using NUnit.Framework;

namespace AssetTool.Test.UETests
{
    public class UETests : TestBase
    {
        [Test] public void Test_UE426_Assets() => Test_UE_Files("UE426_Files", true);
        [Test] public void Test_UE426_Maps() => Test_UE_Files("UE426_Map_Files");
        [Test] public void Test_UE427_Assets() => Test_UE_Files("UE427_Files");
        [Test] public void Test_UE427_Maps() => Test_UE_Files("UE427_Map_Files");
        [Test] public void Test_UE50_Assets() => Test_UE_Files("UE50_Files");
        [Test] public void Test_UE50_Maps() => Test_UE_Files("UE50_Map_Files");
        [Test] public void Test_UE51_Assets() => Test_UE_Files("UE51_Files");
        [Test] public void Test_UE51_Maps() => Test_UE_Files("UE51_Map_Files");
        [Test] public void Test_UE52_Assets() => Test_UE_Files("UE52_Files");
        [Test] public void Test_UE52_Maps() => Test_UE_Files("UE52_Map_Files");
        [Test] public void Test_UE53_Assets() => Test_UE_Files("UE53_Files");
        [Test] public void Test_UE53_Maps() => Test_UE_Files("UE53_Map_Files");
        [Test] public void Test_UE54_Assets() => Test_UE_Files("UE54_Files");
        [Test] public void Test_UE54_Maps() => Test_UE_Files("UE54_Map_Files");
        [Test] public void Test_UE55_Assets() => Test_UE_Files("UE55_Files");
        [Test] public void Test_UE55_Maps() => Test_UE_Files("UE55_Map_Files");
        [Test] public void Test_UE56_Assets() => Test_UE_Files("UE56_Files");
        [Test] public void Test_UE56_Maps() => Test_UE_Files("UE56_Map_Files");
    }
}