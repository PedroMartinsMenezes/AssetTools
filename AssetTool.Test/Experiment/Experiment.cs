using AssetTool.Model;
using AssetTool.Service;
using System.Text;

namespace AssetTool.Test.Experiment
{
    public class StructTestExperiment
    {
        [Fact]
        public void Read_PackageFileSummary_From_Asset()
        {
            string expected = File.ReadAllText("Data/PackageFileSummary.json");
            List<FPackageFileSummary> list = ReadAssetFile(0, 1, reader =>
            {
                FPackageFileSummary item = new();

                reader.Read(ref item.Tag);
                reader.Read(ref item.LegacyFileVersion);
                reader.Read(ref item.LegacyUE3Version);
                reader.Read(ref item.FileVersionUE.FileVersionUE4);
                reader.Read(ref item.FileVersionUE.FileVersionUE5);
                reader.Read(ref item.FileVersionLicenseeUE);
                reader.Read(item.CustomVersionContainer.Versions);
                reader.Read(ref item.TotalHeaderSize);
                reader.Read(ref item.PackageName);
                reader.Read(ref item.PackageFlags);
                reader.Read(ref item.NameCount);
                reader.Read(ref item.NameOffset);
                reader.Read(ref item.SoftObjectPathsCount);
                reader.Read(ref item.SoftObjectPathsOffset);
                reader.Read(ref item.LocalizationId);
                reader.Read(ref item.GatherableTextDataCount);
                reader.Read(ref item.GatherableTextDataOffset);
                reader.Read(ref item.ExportCount);
                reader.Read(ref item.ExportOffset);
                reader.Read(ref item.ImportCount);
                reader.Read(ref item.ImportOffset);
                reader.Read(ref item.DependsOffset);
                reader.Read(ref item.SoftPackageReferencesCount);
                reader.Read(ref item.SoftPackageReferencesOffset);
                reader.Read(ref item.SearchableNamesOffset);
                reader.Read(ref item.ThumbnailTableOffset);
                reader.Read(ref item.Guid);
                reader.Read(ref item.PersistentGuid);
                reader.Read(item.Generations);
                reader.Read(ref item.SavedByEngineVersion);
                reader.Read(ref item.CompatibleWithEngineVersion);
                reader.Read(ref item.CompressionFlags);
                reader.Read(ref item.CompressedChunkSize);
                reader.Read(ref item.PackageSource);
                reader.Read(ref item.AdditionalPackagesToCookSize);
                reader.Read(ref item.AssetRegistryDataOffset);
                reader.Read(ref item.BulkDataStartOffset);
                reader.Read(ref item.WorldTileInfoDataOffset);
                reader.Read(item.ChunkIDs);
                reader.Read(ref item.PreloadDependencyCount);
                reader.Read(ref item.PreloadDependencyOffset);
                reader.Read(ref item.NamesReferencedFromExportDataCount);
                reader.Read(ref item.PayloadTocOffset);
                reader.Read(ref item.DataResourceOffset);

                return item;
            });
            string actual = list[0].ToJson();
            Assert.Equal(expected, actual);
        }

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
            List<FObjectExport> list = ReadAssetFile(2320, 3, reader =>
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
            List<PackageDataMain> list = ReadAssetFile(2681, 1, reader =>
            {
                PackageDataMain item = new();

                reader.Read(ref item.DeserializePackageData.DependencyDataOffset);
                reader.Read(ref item.DeserializePackageData.ObjectCount);
                reader.Read(ref item.ObjectPackageData.ObjectPath);
                reader.Read(ref item.ObjectPackageData.ObjectClassName);
                reader.Read(ref item.ObjectPackageData.TagCount);
                reader.Read(ref item.TagData.Key);
                reader.Read(ref item.TagData.Value);

                return item;
            });
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