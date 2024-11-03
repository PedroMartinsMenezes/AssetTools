namespace AssetTool
{
    public static class GlobalObjects
    {
        static GlobalObjects()
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

        public static Transfer Transfer { get; set; }

        public static AssetObject CurrentObject { get; set; }

        public static FPackageFileSummary PackageFileSummary { get; set; }

        public static List<FSoftObjectPath> SoftObjectPathList { get; set; } = [];

        public static List<FObjectExport> ExportMap { get; set; } = [];

        public static Dictionary<string, Action<Transfer, AssetObject>> AssetMovers { get; } = new();

        public static FPropertyTag TagNone => new FPropertyTag { Name = GlobalNames.None };

        public static string LogStructName { get; set; }

        public static int CustomVer(Guid guid)
        {
            return PackageFileSummary.CustomVersionContainer.Versions.Find(x => x.Key.Value == guid) is FCustomVersion x ? x.Version : -1;
        }

        public static string ExportDiaplayValue(uint i)
        {
            return i < ExportMap.Count ? ExportMap[(int)i].ObjectName.DisplayValue : null;
        }

        public static bool UESupport(EUnrealEngineObjectUE4Version value)
        {
            return PackageFileSummary.FileVersionUE.FileVersionUE4 >= (int)value;
        }

        public static bool UESupport(EUnrealEngineObjectUE5Version value)
        {
            return PackageFileSummary.FileVersionUE.FileVersionUE5 >= (int)value;
        }

        public static bool IsFilterEditorOnly()
        {
            return (PackageFileSummary.PackageFlags & (uint)EPackageFlags.PKG_FilterEditorOnly) > 0;
        }
    }
}
