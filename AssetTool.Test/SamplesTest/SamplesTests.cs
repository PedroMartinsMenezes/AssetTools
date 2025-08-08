using NUnit.Framework;
using System.Collections.Concurrent;
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
            await Parallel.ForEachAsync(files, async (file, ct) =>
            {
                bool success = await StructWriter.RebuildAssetFastAsync(file, "");
                Assert.That(success, file);
            });
            w.Stop();
            TestContext.WriteLine($"File Count   : {files.Length}");
            TestContext.WriteLine($"Total Seconds: {w.Elapsed.TotalSeconds:0.00}");
        }

        [Ignore("Incomplete")]
        [Test]
        public async Task Test_01_UE55_Maps()
        {
            Stopwatch w = new Stopwatch();
            var files = File.ReadAllLines("UE55_Map_Files.txt");
            w.Start();
            await Parallel.ForEachAsync(files, async (file, ct) =>
            {
                bool success = await StructWriter.RebuildAssetFastAsync(file, "");
                Assert.That(success, file);
            });
            w.Stop();
            TestContext.WriteLine($"File Count   : {files.Length}");
            TestContext.WriteLine($"Total Seconds: {w.Elapsed.TotalSeconds:0.00}");
        }

        [Test]
        public async Task Test_01_UE56_Assets()
        {
            Stopwatch w = new Stopwatch();
            ConcurrentBag<string> succeeded = [];
            ConcurrentBag<string> failed = [];
            bool allSucceeded = true;
            var files = File.ReadAllLines("UE56_Files.txt");
            w.Start();
            await Parallel.ForEachAsync(files, async (file, ct) =>
            {
                bool success = await StructWriter.RebuildAssetFastAsync(file, "");
                allSucceeded = allSucceeded & success;
                if (success) succeeded.Add(file); else failed.Add(file);
            });
            w.Stop();
            TestContext.WriteLine($"File Count   : {files.Length}");
            TestContext.WriteLine($"Total Seconds: {w.Elapsed.TotalSeconds:0.00}");
            File.WriteAllLines("UE56_Failed.txt", failed.ToList().OrderBy(x => x));
            File.WriteAllLines("UE56_Succeeded.txt", succeeded.ToList().OrderBy(x => x));
            Assert.That(allSucceeded, $"Failed files: {failed.Count}");
        }

        [Ignore("Incomplete")]
        [Test]
        public async Task Test_01_UE56_Maps()
        {
            Stopwatch w = new Stopwatch();
            var files = File.ReadAllLines("UE56_Map_Files.txt");
            w.Start();
            await Parallel.ForEachAsync(files, async (file, ct) =>
            {
                bool success = await StructWriter.RebuildAssetFastAsync(file, "");
                Assert.That(success, file);
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
            await Parallel.ForEachAsync(files, async (file, ct) =>
            {
                bool success = await StructWriter.RebuildAssetFastAsync(file, "");
                Assert.That(success, file);
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
            await Parallel.ForEachAsync(files, async (file, ct) =>
            {
                bool success = await StructWriter.RebuildAssetFastAsync(file, "");
                Assert.That(success, file);
            });
            w.Stop();
            TestContext.WriteLine($"File Count   : {files.Length}");
            TestContext.WriteLine($"Total Seconds: {w.Elapsed.TotalSeconds:0.00}");
        }

        [Test]
        public async Task Test_04_Lyra_Assets()
        {
            Stopwatch w = new Stopwatch();
            var files = File.ReadAllLines("Lyra_Files.txt");
            w.Start();
            await Parallel.ForEachAsync(files, async (file, ct) =>
            {
                bool success = await StructWriter.RebuildAssetFastAsync(file, "");
                Assert.That(success, file);
            });
            w.Stop();
            TestContext.WriteLine($"File Count   : {files.Length}");
            TestContext.WriteLine($"Total Seconds: {w.Elapsed.TotalSeconds:0.00}");
        }
    }
}