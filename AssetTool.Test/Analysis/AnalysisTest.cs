using NUnit.Framework;
using System.Collections.Generic;
using System.IO;

namespace AssetTool.Test.Analysis
{
    public class AnalysisTest : TestBase
    {
        string[] collectionNames =
        [
            "UE50_Files",
            "UE51_Files",
            "UE52_Files",
            "UE53_Files",
            "UE54_Files",
            "UE55_Files",
            "UE56_Files",

            "UE50_Map_Files",
            "UE51_Map_Files",
            "UE52_Map_Files",
            "UE53_Map_Files",
            "UE54_Map_Files",
            "UE55_Map_Files",
            "UE56_Map_Files",

            "UE400_Files",
            "UE401_Files",
            "UE402_Files",
            "UE403_Files",
            "UE404_Files",
            "UE405_Files",
            "UE406_Files",
            "UE407_Files",
            "UE408_Files",
            "UE409_Files",
            "UE410_Files",
            "UE411_Files",
            "UE412_Files",
            "UE413_Files",
            "UE414_Files",
            "UE415_Files",
            "UE416_Files",
            "UE417_Files",
            "UE418_Files",
            "UE419_Files",
            "UE420_Files",
            "UE421_Files",
            "UE422_Files",
            "UE423_Files",
            "UE424_Files",
            "UE425_Files",
            "UE426_Files",
            "UE427_Files",

            "UE400_Map_Files",
            "UE401_Map_Files",
            "UE402_Map_Files",
            "UE403_Map_Files",
            "UE404_Map_Files",
            "UE405_Map_Files",
            "UE406_Map_Files",
            "UE407_Map_Files",
            "UE408_Map_Files",
            "UE409_Map_Files",
            "UE410_Map_Files",
            "UE411_Map_Files",
            "UE412_Map_Files",
            "UE413_Map_Files",
            "UE414_Map_Files",
            "UE415_Map_Files",
            "UE416_Map_Files",
            "UE417_Map_Files",
            "UE418_Map_Files",
            "UE419_Map_Files",
            "UE420_Map_Files",
            "UE421_Map_Files",
            "UE422_Map_Files",
            "UE423_Map_Files",
            "UE424_Map_Files",
            "UE425_Map_Files",
            "UE426_Map_Files",
            "UE427_Map_Files",
        ];

        [Test]
        public void List_Asset_Types()
        {
            Dictionary<string, List<string>> assetTypes = [];
            foreach (string collection in collectionNames)
            {
                string[] files = File.ReadAllLines($"AssetTool.Test\\InputFiles\\{collection}.txt");
                foreach (string file in files)
                {
                    string assetType = StructWriter.GetAssetType(file);
                    assetTypes.TryAdd(assetType, []);
                    assetTypes[assetType].Add(file);
                }
            }
            File.WriteAllText("C:/Temp/AssetType.json", assetTypes.ToJson());
        }
    }
}
