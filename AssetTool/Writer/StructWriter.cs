using AssetTool.Model;
using AssetTool.Service;

namespace AssetTool.Writer
{
    public static class StructWriter
    {
        public static string Path = "C:\\UE\\AssetTools\\AssetTool\\Data\\S_Endereco2.dat";
        public static string PathExpected = "C:\\UE\\IntroProjectCpp\\Content\\Lab\\S_Endereco.uasset";

        public static void SaveStruct()
        {
            var writer = new BinaryWriter(File.Open(Path, FileMode.Create));
            try
            {
                StructHeader asset = GetStructAsset();
                
                //saving binary
                writer.Write(asset, PathExpected);

                //saving json
                asset.SaveToJson("C:\\UE\\AssetTools\\AssetTool\\Data\\S_Endereco.header.json");
                asset.PackageFileSummary.SaveToJson("C:\\UE\\AssetTools\\AssetTool\\Data\\PackageFileSummary.json");
                asset.NameMap.SaveToJson("C:\\UE\\AssetTools\\AssetTool\\Data\\NameMap.json");
                asset.ImportMap.SaveToJson("C:\\UE\\AssetTools\\AssetTool\\Data\\ImportMap.json");
                asset.ExportMap.SaveToJson("C:\\UE\\AssetTools\\AssetTool\\Data\\ExportMap.json");
                asset.PackageDataMain.SaveToJson("C:\\UE\\AssetTools\\AssetTool\\Data\\PackageDataMain.json");
                asset.OutImportUsedInGame.SaveToJson("C:\\UE\\AssetTools\\AssetTool\\Data\\OutImportUsedInGame.json");
                asset.OutSoftPackageUsedInGame.SaveToJson("C:\\UE\\AssetTools\\AssetTool\\Data\\OutSoftPackageUsedInGame.json");
            }
            finally
            {
                writer.Close();
            }
        }

        private static StructHeader GetStructAsset()
        {
            var obj = new StructHeader();

            obj.PackageFileSummary = GetPackageFileSummary();

            obj.NameMap = GetNameMap();
            obj.PackageFileSummary.NameCount = obj.NameMap.Count;

            obj.ImportMap = GetImportMap();
            obj.PackageFileSummary.ImportCount = obj.ImportMap.Count;

            obj.ExportMap = GetExportMap();
            obj.PackageFileSummary.ExportCount = obj.ExportMap.Count;

            obj.PackageDataMain = GetPackageDataMain();

            obj.OutImportUsedInGame = GetOutImportUsedInGame();
            obj.OutSoftPackageUsedInGame = GetOutSoftPackageUsedInGame();

            return obj;
        }

        private static FPackageFileSummary GetPackageFileSummary() => "Data/PackageFileSummary.json".ReadJson<FPackageFileSummary>();
        private static List<FNameEntrySerialized> GetNameMap() => "Data/NameMap.json".ReadJson<List<FNameEntrySerialized>>();
        private static List<FObjectImport> GetImportMap() => "Data/ImportMap.json".ReadJson<List<FObjectImport>>();
        private static List<FObjectExport> GetExportMap() => "Data/ExportMap.json".ReadJson<List<FObjectExport>>();
        private static XPackageDataMain GetPackageDataMain() => "Data/PackageDataMain.json".ReadJson<XPackageDataMain>();
        private static TBitArray GetOutImportUsedInGame() => "Data/OutImportUsedInGame.json".ReadJson<TBitArray>();
        private static TBitArray GetOutSoftPackageUsedInGame() => "Data/OutSoftPackageUsedInGame.json".ReadJson<TBitArray>();
    }
}
