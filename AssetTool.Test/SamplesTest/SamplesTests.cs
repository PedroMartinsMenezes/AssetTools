using NUnit.Framework;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace AssetTool.Test.SamplesTest
{
    public class SamplesTests : TestBase
    {
        [Test]
        public async Task Test_01_UE55_Assets()
        {
            Stopwatch w = new Stopwatch();
            var files = File.ReadAllLines("UE55_Files.txt");
            w.Start();
            int i = 0;
            await Parallel.ForEachAsync(files, async (file, ct) =>
            {
                bool success = await StructWriter.RebuildAssetFastAsync(file, "");
                Assert.That(success, $"[{i++}] {file}");
            });
            w.Stop();
            TestContext.WriteLine($"File Count   : {files.Length}");
            TestContext.WriteLine($"Total Seconds: {w.Elapsed.TotalSeconds:0.00}");
        }

        [Test]
        public async Task Test_02_Cropout_Assets()
        {
            Stopwatch w = new Stopwatch();
            var files = File.ReadAllLines("Cropout_Files.txt");
            w.Start();
            int i = 0;
            await Parallel.ForEachAsync(files, async (file, ct) =>
            {
                bool success = await StructWriter.RebuildAssetFastAsync(file, "");
                Assert.That(success, $"[{i++}] {file}");
            });
            w.Stop();
            TestContext.WriteLine($"File Count   : {files.Length}");
            TestContext.WriteLine($"Total Seconds: {w.Elapsed.TotalSeconds:0.00}");
        }

        [Test]
        public async Task Test_03_StackOBot_Assets()
        {
            Stopwatch w = new Stopwatch();
            var files = File.ReadAllLines("StackOBot_Files.txt");
            w.Start();
            int i = 0;
            await Parallel.ForEachAsync(files, async (file, ct) =>
            {
                bool success = await StructWriter.RebuildAssetFastAsync(file, "");
                Assert.That(success, $"[{i++}] {file}");
            });
            w.Stop();
            TestContext.WriteLine($"File Count   : {files.Length}");
            TestContext.WriteLine($"Total Seconds: {w.Elapsed.TotalSeconds:0.00}");
        }

        [Test]
        public async Task Test_04_Lyra_Assets()
        {
            Stopwatch w = new Stopwatch();
            List<string> LyraSucceeded = [];
            List<string> LyraFailed = [];
            var files = File.ReadAllLines("Lyra_Files.txt");
            w.Start();
            int i = 0;
            await Parallel.ForEachAsync(files, async (file, ct) =>
            {
                bool success = await StructWriter.RebuildAssetFastAsync(file, "");
                if (success) LyraSucceeded.Add(file); else LyraFailed.Add(file);
                //Assert.That(success, $"[{i++}] {file}");
            });
            w.Stop();
            TestContext.WriteLine($"File Count   : {files.Length}");
            TestContext.WriteLine($"Total Seconds: {w.Elapsed.TotalSeconds:0.00}");
            File.WriteAllLines("Lyra_Failed.txt", LyraFailed);
            File.WriteAllLines("Lyra_Succeeded.txt", LyraSucceeded);
        }

        [Test]
        public async Task Test_04_Lyra_Failed()
        {
            Stopwatch w = new Stopwatch();
            var files = File.ReadAllLines("Lyra_Failed.txt");
            var Lyra_Failed = files.ToList();
            w.Start();
            await Parallel.ForEachAsync(files, async (file, ct) =>
            {
                bool success = await StructWriter.RebuildAssetFastAsync(file, "");
                if (success) Lyra_Failed.Remove(file);
            });
            w.Stop();
            TestContext.WriteLine($"File Count   : {files.Length}");
            TestContext.WriteLine($"Total Seconds: {w.Elapsed.TotalSeconds:0.00}");
            File.WriteAllLines("Lyra_Failed.txt", Lyra_Failed);
        }
    }
}