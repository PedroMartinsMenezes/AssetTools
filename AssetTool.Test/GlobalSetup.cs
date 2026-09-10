using NUnit.Framework;
using System;
using System.Diagnostics;

namespace AssetTool.Test
{
    [SetUpFixture]
    public class GlobalSetup
    {
        private Stopwatch stopwatch = new Stopwatch();

        [OneTimeSetUp]
        public void BeforeAllTests()
        {
            stopwatch.Start();
            TestContext.Progress.WriteLine($"\nAll Started: {DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}\n");
        }

        [OneTimeTearDown]
        public void AfterAllTests()
        {
            TestContext.Progress.WriteLine($"All Ended: {DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}. Seconds: {Math.Round(stopwatch.Elapsed.TotalSeconds, 2)}\n");
        }
    }
}