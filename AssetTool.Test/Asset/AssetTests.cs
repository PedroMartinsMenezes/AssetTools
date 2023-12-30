using AssetTool.Model;
using AssetTool.Service;

namespace AssetTool.Test.Experiment
{
    public class StructTestExperiment
    {
        [Fact]
        public void Read_StructHeader_From_Asset()
        {
            string expected = File.ReadAllText("Data/S_Endereco.header.json");
            var path = "Data/S_Endereco.uasset";
            using var fileStream = new FileStream(path, FileMode.Open);
            using var reader = new BinaryReader(fileStream);
            var asset = new StructHeader();

            asset.PackageFileSummary = reader.Read(new FPackageFileSummary());
            asset.NameMap = reader.ReadList(asset.PackageFileSummary.NameCount, new FNameEntrySerialized());
            asset.ImportMap = reader.ReadList(asset.PackageFileSummary.ImportCount, new FObjectImport());
            asset.TopLevelAssetPath = reader.Read(new FTopLevelAssetPath());
            asset.ExportMap = reader.ReadList(asset.PackageFileSummary.ExportCount, new FObjectExport());
            asset.Gap2 = reader.Read(new Gap2());
            asset.PackageDataMain = reader.Read(new XPackageDataMain());
            asset.OutImportUsedInGame = reader.Read(new TBitArray());
            asset.OutSoftPackageUsedInGame = reader.Read(new TBitArray());

            asset.SaveToJson("C:\\UE\\AssetTools\\AssetTool\\Data\\S_Endereco.header.json");
            string actual = asset.ToJson();
            Assert.Equal(expected, actual);
        }
    }
}