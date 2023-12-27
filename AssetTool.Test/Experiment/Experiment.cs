using AssetTool.Model;
using AssetTool.Service;
using System.Text;

namespace AssetTool.Test.Experiment
{
    public class StructTestExperiment
    {
        [Fact]
        public void Read_NameMap_From_Asset()
        {
            string expected = File.ReadAllText("Data/NameMap.json");
            List<FNameEntrySerialized> list = ReadAssetFile(406, 64, reader =>
            {
                FNameEntrySerialized item = new();

                reader.Read(ref item.Name);
                reader.Read(ref item.DummyHashes[0]);
                reader.Read(ref item.DummyHashes[1]);

                return item;
            });
            string actual = list.ToJson();
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Read_ImportMap_From_Asset()
        {
            string expected = File.ReadAllText("Data/ImportMap.json");
            List<FObjectImport> list = ReadAssetFile(2060, 6, reader =>
            {
                FObjectImport item = new();

                reader.Read(ref item.PackageName);
                reader.Read(ref item.ClassPackage);
                reader.Read(ref item.ClassName);
                reader.Read(ref item.OuterIndex);

                return item;
            });
            string actual = list.ToJson();
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Read_ExportMap_From_Asset()
        {
            string expected = File.ReadAllText("Data/ExportMap.json");
            List<FObjectExport> list = ReadAssetFile<FObjectExport>(2320, 3, reader =>
            {
                FObjectExport item = new();

                reader.Read(ref item.ClassIndex);
                reader.Read(ref item.SuperIndex);
                reader.Read(ref item.TemplateIndex);
                reader.Read(ref item.OuterIndex);
                reader.Read(ref item.ObjectName);
                reader.Read(ref item.SerialSize);
                reader.Read(ref item.SerialOffset);
                reader.Read(ref item.bForcedExport);
                reader.Read(ref item.bNotForClient);
                reader.Read(ref item.bNotForServer);
                reader.Read(ref item.bIsInheritedInstance);
                reader.Read(ref item.PackageFlags);
                reader.Read(ref item.bNotAlwaysLoadedForEditorGame);
                reader.Read(ref item.bIsAsset);
                reader.Read(ref item.bGeneratePublicHash);
                reader.Read(ref item.FirstExportDependency);
                reader.Read(ref item.SerializationBeforeSerializationDependencies);
                reader.Read(ref item.CreateBeforeSerializationDependencies);
                reader.Read(ref item.SerializationBeforeCreateDependencies);
                reader.Read(ref item.CreateBeforeCreateDependencies);

                return item;
            });
            string actual = list.ToJson();
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Read_PackageDataMain_From_Asset()
        {
            string expected = File.ReadAllText("Data/PackageDataMain.json");
            List<PackageDataMain> list = ReadAssetFile<PackageDataMain>(2681, 1, reader =>
            {
                PackageDataMain item = new();

                item.DeserializePackageData.DependencyDataOffset = reader.ReadInt32();



                return item;
            });
            string actual = list.ToJson();
            Assert.Equal(expected, actual);
        }

        #region
        private string ReadAssetFile(int offset, int count, Func<BinaryReader, string> callback)
        {
            var path = "Data/S_Endereco.uasset";

            using var fileStream = new FileStream(path, FileMode.Open);
            fileStream.Seek(offset, SeekOrigin.Begin);
            using var reader = new BinaryReader(fileStream);

            StringBuilder builder = new StringBuilder();

            for (int i = 0; i < count; i++)
            {
                string line = callback(reader);
                builder.AppendLine(line);
            }

            return builder.ToString();
        }

        private List<T> ReadAssetFile<T>(int offset, int count, Func<BinaryReader, T> callback)
        {
            var path = "Data/S_Endereco.uasset";

            using var fileStream = new FileStream(path, FileMode.Open);
            fileStream.Seek(offset, SeekOrigin.Begin);
            using var reader = new BinaryReader(fileStream);

            List<T> list = new List<T>();

            for (int i = 0; i < count; i++)
            {
                T item = callback(reader);
                list.Add(item);
            }

            return list;
        }
        #endregion
    }
}