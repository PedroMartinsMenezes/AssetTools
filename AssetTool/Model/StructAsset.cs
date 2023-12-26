namespace AssetTool.Model
{
    public class StructAsset
    {
        public FPackageFileSummary PackageFileSummary = new();

        public List<FNameEntrySerialized> NameMap = new();

        public List<FObjectImport> ImportMap = new();
    }
}
