namespace AssetTool.Model
{
    //0..2777
    public class StructHeader
    {
        public FPackageFileSummary PackageFileSummary = new();
        public List<FNameEntrySerialized> NameMap = new();
        public List<FObjectImport> ImportMap = new();
        public Gap1 Gap1 = new();
        public List<FObjectExport> ExportMap = new();
        public Gap2 Gap2 = new();
        public XPackageDataMain PackageDataMain = new();
        public TBitArray OutImportUsedInGame = new();
        public TBitArray OutSoftPackageUsedInGame = new();
    }
}
