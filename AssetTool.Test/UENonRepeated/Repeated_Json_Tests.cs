using NUnit.Framework;
using System.IO;

namespace AssetTool.Test.UENonRepeated
{
    public class Repeated_Json_Tests : TestBase
    {
        [Test]
        public void Delete_Repeated_Json_Files()
        {
            string[] files = File.ReadAllLines("AssetTool.Test\\InputFiles\\RepeatedJsonFiles.txt");
            foreach (string file in files)
            {
                if (File.Exists(file))
                    File.Delete(file);
            }
        }
    }
}