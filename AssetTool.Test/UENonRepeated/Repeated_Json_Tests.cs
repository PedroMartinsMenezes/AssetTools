using NUnit.Framework;
using System.IO;

namespace AssetTool.Test.UENonRepeated
{
    [Ignore("Already done")]
    public class Repeated_Json_Tests : TestBase
    {
        [Test]
        public void Delete_Repeated_Json_Files()
        {
            int count = 0;
            string[] files = File.ReadAllLines("AssetTool.Test\\InputFiles\\RepeatedJsonFiles.txt");
            foreach (string file in files)
            {
                if (File.Exists(file))
                {
                    count++;
                    File.Delete(file);
                }
            }
            TestContext.WriteLine("Total files deleted: " + count);
        }
    }
}