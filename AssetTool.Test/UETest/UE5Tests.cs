using NUnit.Framework;

namespace AssetTool.Test.UE5Tests
{
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

    [NonParallelizable]
    public class UE5AssetTests : TestBase
    {
        [Order(1)]
        [Test] public void Test_UE50_Assets() => Test_UE_Files("UE50_Files");
        [Order(2)]
        [Test] public void Test_UE51_Assets() => Test_UE_Files("UE51_Files");
        [Order(3)]
        [Test] public void Test_UE52_Assets() => Test_UE_Files("UE52_Files");
        [Order(4)]
        [Test] public void Test_UE53_Assets() => Test_UE_Files("UE53_Files");
        [Order(5)]
        [Test] public void Test_UE54_Assets() => Test_UE_Files("UE54_Files");
        [Order(6)]
        [Test] public void Test_UE55_Assets() => Test_UE_Files("UE55_Files");
        [Order(7)]
        [Test] public void Test_UE56_Assets() => Test_UE_Files("UE56_Files");
    }
}
