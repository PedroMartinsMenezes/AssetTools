namespace AssetTool
{
    public class GlobalObjects
    {
        public GlobalObjects()
        {
            JsonAssetAttribute.TypesAndAttributes.ToList().ForEach(t =>
            {
                AssetMovers.Add(t.Item2.TypeName, (transfer, myAsset) =>
                {
                    myAsset.Obj = myAsset.Obj ?? (UObject)Activator.CreateInstance(t.Item1);
                    myAsset.Obj.Move(transfer);
                });
            });
        }

        ///public Transfer Transfer { get; set; }

        public AssetObject CurrentObject { get; set; }

        public FPackageFileSummary PackageFileSummary { get; set; }

        public List<FSoftObjectPath> SoftObjectPathList { get; set; } = [];

        public List<FObjectExport> ExportMap { get; set; } = [];

        public Dictionary<string, Action<Transfer, AssetObject>> AssetMovers { get; } = new();

        public string LogStructName { get; set; }

        public HashSet<string> UnicodeStrings { get; set; } = [];

        public string FileName { get; set; }

        public int CustomVer(Guid guid)
        {
            return PackageFileSummary.CustomVersionContainer.Versions.Find(x => x.Key.Value == guid) is FCustomVersion x ? x.Version : -1;
        }

        public string ExportDiaplayValue(uint i)
        {
            return i < ExportMap.Count ? ExportMap[(int)i].ObjectName.DisplayValue : null;
        }

        public bool UESupport(EUnrealEngineObjectUE4Version value)
        {
            return PackageFileSummary.FileVersionUE.FileVersionUE4 >= (int)value;
        }

        public bool UESupport(EUnrealEngineObjectUE5Version value)
        {
            return PackageFileSummary.FileVersionUE.FileVersionUE5 >= (int)value;
        }

        public bool IsFilterEditorOnly()
        {
            return (PackageFileSummary.PackageFlags & (uint)EPackageFlags.PKG_FilterEditorOnly) > 0;
        }
    }
}
