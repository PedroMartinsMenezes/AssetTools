namespace AssetTool.Model
{
    //0..2777
    public class StructHeader
    {
        public FPackageFileSummary PackageFileSummary = new();
        public List<FNameEntrySerialized> NameMap = new();
        public List<FObjectImport> ImportMap = new();
        public FTopLevelAssetPath TopLevelAssetPath = new();
        public List<FObjectExport> ExportMap = new();
        public Gap2 Gap2 = new();
        public XPackageDataMain PackageDataMain = new();
        public TBitArray OutImportUsedInGame = new();
        public TBitArray OutSoftPackageUsedInGame = new();
    }
}
