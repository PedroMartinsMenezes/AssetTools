using NUnit.Framework;
using System.Diagnostics;
using System.IO;

namespace AssetTool.Test.StackOBotTest
{
    public class StackOBotTests : TestBase
    {
        [Test]
        public async System.Threading.Tasks.Task Test_StackOBot_All()
        {
            Stopwatch w = new Stopwatch();
            var files = File.ReadAllLines("StackOBot_Files.txt");
            w.Start();
            int i = 0;
            await System.Threading.Tasks.Parallel.ForEachAsync(files, async (file, ct) =>
            {
                bool success = await StructWriter.RebuildAssetFastAsync(file, "");
                Assert.That(success, $"[{i++}] {file}");
            });
            w.Stop();
            TestContext.WriteLine($"File Count   : {files.Length}");
            TestContext.WriteLine($"Total Seconds: {w.Elapsed.TotalSeconds:0.00}");
        }
    }
}