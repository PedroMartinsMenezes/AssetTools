using NUnit.Framework;

namespace AssetTool.Test.UETests
{
    public class UE4MapTests : TestBase
    {
        [Test] public void Test_UE417_Maps() => Test_UE_Files("UE417_Map_Files");
        [Test] public void Test_UE418_Maps() => Test_UE_Files("UE418_Map_Files");
        [Test] public void Test_UE419_Maps() => Test_UE_Files("UE419_Map_Files");
        [Test] public void Test_UE420_Maps() => Test_UE_Files("UE420_Map_Files");
        [Test] public void Test_UE421_Maps() => Test_UE_Files("UE421_Map_Files");
        [Test] public void Test_UE422_Maps() => Test_UE_Files("UE422_Map_Files");
        [Test] public void Test_UE423_Maps() => Test_UE_Files("UE423_Map_Files");
        [Test] public void Test_UE424_Maps() => Test_UE_Files("UE424_Map_Files");
        [Test] public void Test_UE425_Maps() => Test_UE_Files("UE425_Map_Files");
        [Test] public void Test_UE426_Maps() => Test_UE_Files("UE426_Map_Files");
        [Test] public void Test_UE427_Maps() => Test_UE_Files("UE427_Map_Files");
    }

    public class UE5MapTests : TestBase
    {
        [Test] public void Test_UE50_Maps() => Test_UE_Files("UE50_Map_Files");
        [Test] public void Test_UE51_Maps() => Test_UE_Files("UE51_Map_Files");
        [Test] public void Test_UE52_Maps() => Test_UE_Files("UE52_Map_Files");
        [Test] public void Test_UE53_Maps() => Test_UE_Files("UE53_Map_Files");
        [Test] public void Test_UE54_Maps() => Test_UE_Files("UE54_Map_Files");
        [Test] public void Test_UE55_Maps() => Test_UE_Files("UE55_Map_Files");
        [Test] public void Test_UE56_Maps() => Test_UE_Files("UE56_Map_Files");
    }
}