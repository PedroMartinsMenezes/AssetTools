using NUnit.Framework;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace AssetTool.Test.UETests
{
    public class UETests : TestBase
    {
        [Test]
        public async Task Test_01_UE56_Assets()
        {
            Stopwatch w = new Stopwatch();
            var files = File.ReadAllLines("UE56_Files.txt");
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
        public async Task Test_01_UE56_Maps()
        {
            Stopwatch w = new Stopwatch();
            var files = File.ReadAllLines("UE56_Map_Files.txt");
            w.Start();
            foreach (var file in files)
            {
                bool success = await StructWriter.RebuildAssetFastAsync(file, "");
                Assert.That(success, file);
            }
            w.Stop();
            TestContext.WriteLine($"File Count   : {files.Length}");
            TestContext.WriteLine($"Total Seconds: {w.Elapsed.TotalSeconds:0.00}");
        }

        [Test]
        public async Task Test_02_UE55_Assets()
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

        [Test]
        public async Task Test_02_UE55_Maps()
        {
            Stopwatch w = new Stopwatch();
            var files = File.ReadAllLines("UE55_Map_Files.txt");
            w.Start();
            foreach (var file in files)
            {
                bool success = await StructWriter.RebuildAssetFastAsync(file, "");

                if (!success)
                {
                    string path = "AssetTool\\Properties\\launchSettings.json";
                    string[] lines = File.ReadAllLines(path);
                    lines[5] = $"      \"commandLineArgs\": \"{file.Replace('\\', '/')} -log\"";
                    File.WriteAllLines(path, lines);
                }

                Assert.That(success, $"[{files.ToList().IndexOf(file)}] {file}");
            }
            w.Stop();
            TestContext.WriteLine($"File Count   : {files.Length}");
            TestContext.WriteLine($"Total Seconds: {w.Elapsed.TotalSeconds:0.00}");
        }


    }
}