using NUnit.Framework;
using System.Diagnostics;
using System.IO;
using System.Linq;

namespace AssetTool.Test.StackOBotTest
{
    public class StackOBotTests : TestBase
    {
        [Ignore("Fix")]
        [Test]
        public async System.Threading.Tasks.Task Test_StackOBot_All()
        {
            Stopwatch w = new Stopwatch();
            var files = File.ReadAllLines("StackOBot_Files.txt");
            w.Start();
            int i = 0;
            await System.Threading.Tasks.Parallel.ForEachAsync(files, async (file, ct) =>
            //foreach (string file in files)
            {
                bool success = await StructWriter.RebuildAssetFastAsync(file, "");
                Assert.That(success, $"[{i++}] {file}");
                //}
            });
            w.Stop();
            TestContext.WriteLine($"File Count   : {files.Length}");
            TestContext.WriteLine($"Total Seconds: {w.Elapsed.TotalSeconds:0.00}");
        }

        [Test]
        public async System.Threading.Tasks.Task Test_StackOBot_ExternalActors()
        {
            Stopwatch w = new Stopwatch();
            var files = File.ReadAllLines("StackOBot_Files.txt");
            w.Start();
            int i = 0;
            //await System.Threading.Tasks.Parallel.ForEachAsync(files, async (file, ct) =>
            foreach (string file in files)
            {
                bool success = await StructWriter.RebuildAssetFastAsync(file, "");
                //File.AppendAllText("C:/Temp/StackOBot.txt", $"[{success}] {file}\n");
                Assert.That(success, $"[{i++}] {file}");
            }
            //});
            w.Stop();
            TestContext.WriteLine($"File Count   : {files.Length}");
            TestContext.WriteLine($"Total Seconds: {w.Elapsed.TotalSeconds:0.00}");
        }

        [Test]
        public async System.Threading.Tasks.Task Test_StackOBot_OK()
        {
            Stopwatch w = new Stopwatch();
            var files = File.ReadAllLines("StackOBot_Files.txt").Where(x => !x.Contains("__ExternalActors__")).ToArray();
            w.Start();
            int i = 0;
            await System.Threading.Tasks.Parallel.ForEachAsync(files, async (file, ct) =>
            //foreach (string file in files)
            {
                bool success = await StructWriter.RebuildAssetFastAsync(file, "");
                Assert.That(success, $"[{i++}] {file}");
                //}
            });
            w.Stop();
            TestContext.WriteLine($"File Count   : {files.Length}");
            TestContext.WriteLine($"Total Seconds: {w.Elapsed.TotalSeconds:0.00}");
        }
    }
}