namespace AssetTool.Model
{
    public class StructAsset
    {
        public FPackageFileSummary PackageFileSummary = new();
        public List<FNameEntrySerialized> NameMap = new();
        public List<FObjectImport> ImportMap = new();
        public List<FObjectExport> ExportMap = new();
        public XPackageDataMain PackageDataMain = new();
        public TBitArray OutImportUsedInGame = new();
        public TBitArray OutSoftPackageUsedInGame = new();
    }
}
