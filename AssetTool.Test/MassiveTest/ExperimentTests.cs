using NUnit.Framework;
using System;
using System.Diagnostics;
using System.IO;
using System.Threading.Tasks;

namespace AssetTool.Test.MassiveTest
{
    public class ExperimentTests : TestBase
    {
        [Test]
        [Ignore("Experimental")]
        public async Task Test_UE55_Assets_Succeeded_Read_ForEachAsync()
        {
            Stopwatch w = new Stopwatch();
            var files = File.ReadAllLines("UE55AssetsSucceeded.txt");
            w.Start();
            int i = 0;
            string currentFile = default;
            try
            {
                var options = new ParallelOptions { MaxDegreeOfParallelism = Environment.ProcessorCount };
                await Parallel.ForEachAsync(files, options, async (file, ct) =>
                {
                    currentFile = file;
                    bool success = await StructWriter.ReadAssetAsync(file);
                    Assert.That(success, $"[{i++}] {file}");
                });
            }
            catch (System.Exception ex)
            {
                TestContext.WriteLine($"Error: {ex.Message}\n{currentFile}");
                throw;
            }
            w.Stop();
            TestContext.WriteLine($"File Count   : {files.Length}");
            TestContext.WriteLine($"Total Seconds: {w.Elapsed.TotalSeconds:0.00}");
        }

        [Test]
        [Ignore("Experimental")]
        public void Test_UE55_Assets_Succeeded_Read_ForEach()
        {
            Stopwatch w = new Stopwatch();
            var files = File.ReadAllLines("UE55AssetsSucceeded.txt");
            w.Start();
            int i = 0;
            string currentFile = default;
            try
            {
                var options = new ParallelOptions { MaxDegreeOfParallelism = Environment.ProcessorCount };
                Parallel.ForEach(files, options, (file, ct) =>
                {
                    currentFile = file;
                    bool success = StructWriter.ReadAsset(file);
                    Assert.That(success, $"[{i++}] {file}");
                });
            }
            catch (System.Exception ex)
            {
                TestContext.WriteLine($"Error: {ex.Message}\n{currentFile}");
                throw;
            }
            w.Stop();
            TestContext.WriteLine($"File Count   : {files.Length}");
            TestContext.WriteLine($"Total Seconds: {w.Elapsed.TotalSeconds:0.00}");
        }
    }
}