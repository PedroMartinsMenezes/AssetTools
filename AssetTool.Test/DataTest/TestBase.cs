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
                Log.Enabled = true;
            }
        }
    }
}