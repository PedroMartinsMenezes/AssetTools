using NUnit.Framework;

namespace AssetTool.Test.UESequential
{
    [NonParallelizable]
    public class UE50AssetTests : TestBase
    {
        [Test] public void Test_UE50_Assets() => Test_UE_Files_Sequential("UE50_Files");
    }
    [NonParallelizable]
    public class UE51AssetTests : TestBase
    {
        [Test] public void Test_UE51_Assets() => Test_UE_Files_Sequential("UE51_Files");
    }
    [NonParallelizable]
    public class UE52AssetTests : TestBase
    {
        [Test] public void Test_UE52_Assets() => Test_UE_Files_Sequential("UE52_Files");
    }
    [NonParallelizable]
    public class UE53AssetTests : TestBase
    {
        [Test] public void Test_UE53_Assets() => Test_UE_Files_Sequential("UE53_Files");
    }
    [NonParallelizable]
    public class UE54AssetTests : TestBase
    {
        [Test] public void Test_UE54_Assets() => Test_UE_Files_Sequential("UE54_Files");
    }
    [NonParallelizable]
    public class UE55AssetTests : TestBase
    {
        [Test] public void Test_UE55_Assets() => Test_UE_Files_Sequential("UE55_Files");
    }
    [NonParallelizable]
    public class UE56AssetTests : TestBase
    {
        [Test] public void Test_UE56_Assets() => Test_UE_Files_Sequential("UE56_Files");
    }
}
