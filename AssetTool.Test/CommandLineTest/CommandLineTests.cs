using NUnit.Framework;
using System.Diagnostics;
using System.IO;

namespace AssetTool.Test.CommandLine
{
    public class CommandLineTests
    {
        [Test]
        public void JsonToAsset_Should_Succeed()
        {
            Stopwatch w = new Stopwatch();
            string[] files = Directory.GetFiles("..\\..\\..\\..\\Data\\Output", "*.json", SearchOption.AllDirectories);
            w.Start();
            int i = 0;
            foreach (string file in files)
            {
                bool success = StructWriter.RunJsonToUasset(file, null);
                Assert.That(success, $"[{i++}] {file}");
            }
            w.Stop();
            TestContext.WriteLine($"File Count   : {files.Length}");
            TestContext.WriteLine($"Total Seconds: {w.Elapsed.TotalSeconds:0.00}");
        }
    }
}
