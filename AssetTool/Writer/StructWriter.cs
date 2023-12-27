using AssetTool.Model;
using AssetTool.Model.Basic;
using AssetTool.Service;

namespace AssetTool.Writer
{
    public static class StructWriter
    {
        public static string Path = "C:\\UE\\IntroProjectCpp\\Content\\Lab\\S_Endereco2.dat";
        public static string PathExpected = "C:\\UE\\IntroProjectCpp\\Content\\Lab\\S_Endereco.uasset";

        public static void SaveStruct()
        {
            var writer = new BinaryWriter(File.Open(Path, FileMode.Create));
            try
            {
                StructAsset asset = GetStructAsset();
                writer.Write(asset);
            }
            finally
            {
                if (writer is { })
                    writer.Close();
            }
        }

        private static StructAsset GetStructAsset()
        {
            var summary = GetPackageFileSummary();

            var nameMap = GetNameMap();
            summary.NameCount = nameMap.Count;

            var importMap = GetImportMap();
            summary.ImportCount = importMap.Count;

            var exportMap = GetExportMap();
            summary.ExportCount = exportMap.Count;

            return new StructAsset
            {
                PackageFileSummary = summary,
                NameMap = nameMap,
                ImportMap = importMap,
                ExportMap = exportMap,
            };
        }

        private static FPackageFileSummary GetPackageFileSummary()
        {
            var Sum = new FPackageFileSummary();

            Sum.Tag = -1641380927;

            Sum.LegacyFileVersion = -8;
            Sum.LegacyUE3Version = 864;

            Sum.FileVersionUE.FileVersionUE4 = 522;
            Sum.FileVersionUE.FileVersionUE5 = 1009;
            Sum.FileVersionLicenseeUE = 0;

            Sum.CustomVersionContainer.Add(04, "375EC13C-06E4-48FB-B500-84F0262A717E");
            Sum.CustomVersionContainer.Add(37, "CFFC743F-43B0-4480-9391-14DF171D2073");
            Sum.CustomVersionContainer.Add(47, "D89B5E42-24BD-4D46-8412-ACA8DF641779");
            Sum.CustomVersionContainer.Add(40, "E4B068ED-F494-42E9-A231-DA0B2E46BB41");

            Sum.TotalHeaderSize = 2777;
            Sum.PackageName = "/Game/Lab/S_Endereco";

            Sum.PackageFlags = 0;
            Sum.NameCount = 64;
            Sum.NameOffset = 406;
            Sum.SoftObjectPathsCount = 1;
            Sum.SoftObjectPathsOffset = 2060;
            Sum.LocalizationId = "F2C39EE34438D2D11BCA9BE4B49FD4BB";
            Sum.GatherableTextDataCount = 0;
            Sum.GatherableTextDataOffset = 2080;
            Sum.ExportCount = 3;
            Sum.ExportOffset = 2320;
            Sum.ImportCount = 6;
            Sum.ImportOffset = 2080;
            Sum.DependsOffset = 2608;
            Sum.SoftPackageReferencesCount = 0;
            Sum.SoftPackageReferencesOffset = 2620;
            Sum.SearchableNamesOffset = 2620;
            Sum.ThumbnailTableOffset = 2636;
            Sum.Guid = new Guid("F542184A-4CB1-0F09-B220-E99C7E04D5ED");
            Sum.PersistentGuid = new Guid("1D422EA2-4FBF-3347-B155-6695C91C5934");
            Sum.AddGeneration(3, 64);
            Sum.SavedByEngineVersion.Set(5, 3, 2, 29314046, "++UE5+Release-5.3");
            Sum.CompatibleWithEngineVersion.Set(5, 3, 0, 27405482, "++UE5+Release-5.3");
            Sum.CompressionFlags = 0;
            Sum.CompressedChunkSize = 0;
            Sum.PackageSource = 742339551;
            Sum.AdditionalPackagesToCookSize = 0;
            Sum.AssetRegistryDataOffset = 2681;//
            Sum.BulkDataStartOffset = 8054;//
            Sum.WorldTileInfoDataOffset = 0;
            Sum.ChunkIDsSize = 0;
            Sum.PreloadDependencyCount = -1;
            Sum.PreloadDependencyOffset = 2777;
            Sum.NamesReferencedFromExportDataCount = 53;
            Sum.PayloadTocOffset = 8058;
            Sum.DataResourceOffset = 0;

            return Sum;
        }

        private static List<FNameEntrySerialized> GetNameMap()
        {
            return SerializerExt.ReadJson<List<FNameEntrySerialized>>("Data/NameMap.json");
        }

        private static List<FObjectImport> GetImportMap()
        {
            return SerializerExt.ReadJson<List<FObjectImport>>("Data/ImportMap.json");
        }

        private static List<FObjectExport> GetExportMap()
        {
            return SerializerExt.ReadJson<List<FObjectExport>>("Data/ExportMap.json");
        }
    }
}
