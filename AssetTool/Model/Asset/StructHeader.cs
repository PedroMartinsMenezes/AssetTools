using System.Text.Json.Serialization;

namespace AssetTool.Model
{
    public class StructHeader
    {
        public FPackageFileSummary PackageFileSummary = new();
        public List<FNameEntrySerialized> NameMap = new();
        public List<FObjectImport> ImportMap = new();
        [JsonIgnore] public byte[] Gap1 = new byte[20]; //TODO Gap fix
        public List<FObjectExport> ExportMap = new();
        [JsonIgnore] public byte[] Gap2 = new byte[73]; //TODO Gap fix
        public XPackageDataMain PackageDataMain = new();
        public TBitArray OutImportUsedInGame = new();
        public TBitArray OutSoftPackageUsedInGame = new();
    }
}
