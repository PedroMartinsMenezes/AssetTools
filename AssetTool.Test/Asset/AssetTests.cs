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
            asset.Gap1 = reader.Read(new Gap1());
            asset.ExportMap = reader.ReadList(asset.PackageFileSummary.ExportCount, new FObjectExport());
            reader.Read(asset.Gap2);
            asset.PackageDataMain = reader.Read(new XPackageDataMain());
            asset.OutImportUsedInGame = reader.Read(new TBitArray());
            asset.OutSoftPackageUsedInGame = reader.Read(new TBitArray());

            string actual = asset.ToJson();
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Read_PackageFileSummary_From_Asset()
        {
            string expected = File.ReadAllText("Data/PackageFileSummary.json");
            List<FPackageFileSummary> list = ReadAssetFile(0, 1, reader => reader.Read(new FPackageFileSummary()));
            string actual = list[0].ToJson();
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Read_NameMap_From_Asset()
        {
            string expected = File.ReadAllText("Data/NameMap.json");
            List<FNameEntrySerialized> list = ReadAssetFile(406, 64, reader => reader.Read(new FNameEntrySerialized()));
            string actual = list.ToJson();
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Read_ImportMap_From_Asset()
        {
            string expected = File.ReadAllText("Data/ImportMap.json");
            List<FObjectImport> list = ReadAssetFile(2060, 6, reader => reader.Read(new FObjectImport()));
            string actual = list.ToJson();
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Read_ExportMap_From_Asset()
        {
            string expected = File.ReadAllText("Data/ExportMap.json");
            List<FObjectExport> list = ReadAssetFile(2320, 3, reader => reader.Read(new FObjectExport()));
            string actual = list.ToJson();
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Read_PackageDataMain_From_Asset()
        {
            string expected = File.ReadAllText("Data/PackageDataMain.json");
            List<XPackageDataMain> list = ReadAssetFile(2681, 1, reader => reader.Read(new XPackageDataMain()));
            string actual = list[0].ToJson();
            Assert.Equal(expected, actual);
        }

        #region Helpers
        private List<T> ReadAssetFile<T>(int offset, int count, Func<BinaryReader, T> callback)
        {
            var path = "Data/S_Endereco.uasset";
            using var fileStream = new FileStream(path, FileMode.Open);
            fileStream.Seek(offset, SeekOrigin.Begin);
            using var reader = new BinaryReader(fileStream);
            return Enumerable.Range(0, count).Select(x => callback(reader)).ToList();
        }
        #endregion
    }
}