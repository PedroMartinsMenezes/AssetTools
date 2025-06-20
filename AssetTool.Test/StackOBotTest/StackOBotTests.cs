using NUnit.Framework;
using System.Diagnostics;
using System.IO;

namespace AssetTool.Test.StackOBotTest
{
    public class StackOBotTests : TestBase
    {
        [Test]
        public async System.Threading.Tasks.Task Test_StackOBot_Succeeded()
        {
            Stopwatch w = new Stopwatch();
            var files = File.ReadAllLines("StackOBot_Succeeded.txt");
            w.Start();
            int i = 0;
            await System.Threading.Tasks.Parallel.ForEachAsync(files, async (file, ct) =>
            //foreach (string file in files)
            {
                AppConfig.DebugSaveHeader = false;
                AppConfig.DebugSaveReconstructed = false;
                AppConfig.DebugSaveUnitTest = false;
                AppConfig.DebugSaveMember = false;
                AppConfig.DebugCheckMember = false;
                Log.Enabled = false;
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