using NUnit.Framework;

namespace AssetTool.Test.UETests
{
    public class UE4AssetTests : TestBase
    {
        [Test][Ignore("Broken")] public void Test_UE420_Assets() => Test_UE_Files("UE420_Files");
        [Test] public void Test_UE421_Assets() => Test_UE_Files("UE421_Files");
        [Test] public void Test_UE422_Assets() => Test_UE_Files("UE422_Files");
        [Test] public void Test_UE423_Assets() => Test_UE_Files("UE423_Files");
        [Test] public void Test_UE424_Assets() => Test_UE_Files("UE424_Files");
        [Test] public void Test_UE425_Assets() => Test_UE_Files("UE425_Files");
        [Test] public void Test_UE426_Assets() => Test_UE_Files("UE426_Files");
        [Test] public void Test_UE427_Assets() => Test_UE_Files("UE427_Files");
    }

    public class UE5AssetTests : TestBase
    {
        [Test] public void Test_UE50_Assets() => Test_UE_Files("UE50_Files");
        [Test] public void Test_UE51_Assets() => Test_UE_Files("UE51_Files");
        [Test] public void Test_UE52_Assets() => Test_UE_Files("UE52_Files");
        [Test] public void Test_UE53_Assets() => Test_UE_Files("UE53_Files");
        [Test] public void Test_UE54_Assets() => Test_UE_Files("UE54_Files");
        [Test] public void Test_UE55_Assets() => Test_UE_Files("UE55_Files");
        [Test] public void Test_UE56_Assets() => Test_UE_Files("UE56_Files");
    }
}