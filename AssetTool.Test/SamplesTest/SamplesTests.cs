using NUnit.Framework;
using System.Diagnostics;
using System.IO;
using System.Threading.Tasks;

namespace AssetTool.Test.SamplesTest
{
    public class SamplesTests : TestBase
    {
        [Test]
        public void Test_Cropout_Assets()
        {
            Stopwatch w = new Stopwatch();
            var files = File.ReadAllLines("AssetTool.Test\\InputFiles\\Cropout_Files.txt");
            w.Start();
            Parallel.ForEach(files, file =>
            {
                bool success = StructWriter.RebuildAssetFast(file, "");
                Assert.That(success, file);
            });
            w.Stop();
            TestContext.WriteLine($"File Count   : {files.Length}");
            TestContext.WriteLine($"Total Seconds: {w.Elapsed.TotalSeconds:0.00}");
        }

        [Test]
        public void Test_StackOBot_Assets()
        {
            Stopwatch w = new Stopwatch();
            var files = File.ReadAllLines("AssetTool.Test\\InputFiles\\StackOBot_Files.txt");
            w.Start();
            Parallel.ForEach(files, file =>
            {
                bool success = StructWriter.RebuildAssetFast(file, "");
                Assert.That(success, file);
            });
            w.Stop();
            TestContext.WriteLine($"File Count   : {files.Length}");
            TestContext.WriteLine($"Total Seconds: {w.Elapsed.TotalSeconds:0.00}");
        }

        [Test]
        public void Test_Lyra_Assets()
        {
            Stopwatch w = new Stopwatch();
            var files = File.ReadAllLines("AssetTool.Test\\InputFiles\\Lyra_Files.txt");
            w.Start();
            Parallel.ForEach(files, file =>
            {
                bool success = StructWriter.RebuildAssetFast(file, "");
                Assert.That(success, file);
            });
            w.Stop();
            TestContext.WriteLine($"File Count   : {files.Length}");
            TestContext.WriteLine($"Total Seconds: {w.Elapsed.TotalSeconds:0.00}");
        }
    }
}