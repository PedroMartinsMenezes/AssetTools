using NUnit.Framework;
using System;
using System.Globalization;
using System.IO;

namespace AssetTool.Test
{
    public class TestBase
    {
        static bool initialized = false;

        public TestBase()
        {
            var cultureInfo = CultureInfo.InvariantCulture;
            CultureInfo.DefaultThreadCurrentCulture = cultureInfo;
            CultureInfo.DefaultThreadCurrentUICulture = cultureInfo;

            if (!initialized)
            {
                initialized = true;
                Directory.SetCurrentDirectory("..\\..\\..\\..\\");
            }
        }

        [TearDown]
        public void TearDown()
        {
            TestContext.WriteLine(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
        }
    }
}