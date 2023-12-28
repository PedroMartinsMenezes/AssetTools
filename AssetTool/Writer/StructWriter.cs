using AssetTool.Model;
using AssetTool.Service;

namespace AssetTool.Writer
{
    public static class StructWriter
    {
        public static string Path = "Data\\S_Endereco2.dat";
        public static string PathExpected = "C:\\UE\\IntroProjectCpp\\Content\\Lab\\S_Endereco.uasset";

        public static void SaveStruct()
        {
            var writer = new BinaryWriter(File.Open(Path, FileMode.Create));
            try
            {
                StructAsset asset = GetStructAsset();
                writer.Write(asset, PathExpected);
            }
            finally
            {
                writer.Close();
            }
        }

        private static StructAsset GetStructAsset()
        {
            var obj = new StructAsset();

            obj.PackageFileSummary = GetPackageFileSummary();

            obj.NameMap = GetNameMap();
            obj.PackageFileSummary.NameCount = obj.NameMap.Count;

            obj.ImportMap = GetImportMap();
            obj.PackageFileSummary.ImportCount = obj.ImportMap.Count;

            obj.ExportMap = GetExportMap();
            obj.PackageFileSummary.ExportCount = obj.ExportMap.Count;

            obj.PackageDataMain = GetPackageDataMain();

            return obj;
        }

        private static FPackageFileSummary GetPackageFileSummary() => "Data/PackageFileSummary.json".ReadJson<FPackageFileSummary>();
        private static List<FNameEntrySerialized> GetNameMap() => "Data/NameMap.json".ReadJson<List<FNameEntrySerialized>>();
        private static List<FObjectImport> GetImportMap() => "Data/ImportMap.json".ReadJson<List<FObjectImport>>();
        private static List<FObjectExport> GetExportMap() => "Data/ExportMap.json".ReadJson<List<FObjectExport>>();
        private static PackageDataMain GetPackageDataMain() => "Data/PackageDataMain.json".ReadJson<PackageDataMain>();
    }
}
