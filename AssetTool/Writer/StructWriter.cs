using AssetTool.Model;
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
            return "Data/PackageFileSummary.json".ReadObject<FPackageFileSummary>();
        }

        private static List<FNameEntrySerialized> GetNameMap()
        {
            return "Data/NameMap.json".ReadObject<List<FNameEntrySerialized>>();
        }

        private static List<FObjectImport> GetImportMap()
        {
            return "Data/ImportMap.json".ReadObject<List<FObjectImport>>();
        }

        private static List<FObjectExport> GetExportMap()
        {
            return "Data/ExportMap.json".ReadObject<List<FObjectExport>>();
        }
    }
}
