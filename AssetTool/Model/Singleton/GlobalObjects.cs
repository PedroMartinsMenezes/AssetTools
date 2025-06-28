namespace AssetTool
{
    public class GlobalObjects
    {
        static GlobalObjects()
        {
            //Registering classes with UCLASS attribute
            JsonAssetAttribute.TypesAndAttributes.ToList().ForEach((Action<(Type, JsonAssetAttribute)>)(t =>
            {
                AssetMovers.Add(t.Item2.TypeName, (Action<Transfer, AssetObject>)((transfer, myAsset) =>
                {
                    myAsset.Obj = myAsset.Obj ?? (UObject)Activator.CreateInstance(t.Item1);
                    myAsset.Obj.bIsUClass = true;
                    myAsset.Obj.Move(transfer);
                }));

                if (t.Item2.TypeNameDeprecated is { })
                {
                    //Registering classes with UCLASS attribute
                    AssetMovers.Add(t.Item2.TypeNameDeprecated, (Action<Transfer, AssetObject>)((transfer, myAsset) =>
                    {
                        myAsset.Obj = myAsset.Obj ?? (UObject)Activator.CreateInstance(t.Item1);
                        myAsset.Obj.bIsUClass = true;
                        myAsset.Obj.Move(transfer);
                    }));
                }
            }));
        }

        #region Static Members

        public static Dictionary<string, Action<Transfer, AssetObject>> AssetMovers { get; } = new();

        #endregion

        #region Dynamic Members

        public AssetObject CurrentObject { get; set; }

        public FPackageFileSummary PackageFileSummary { get; set; }

        public List<FSoftObjectPath> SoftObjectPathList { get; set; } = [];

        public List<FObjectExport> ExportMap { get; set; } = [];

        public string LogStructName { get; set; }

        public HashSet<string> UnicodeStrings { get; set; } = [];

        public string FileName { get; set; }

        public Dictionary<long, FPropertyTag> MemberSizes { get; set; } = [];

        #endregion

        public int CustomVer(Guid guid)
        {
            return PackageFileSummary.CustomVersionContainer.Versions.Find(x => x.Key.Value == guid) is FCustomVersion x ? x.Version : -1;
        }

        public string ExportDiaplayValue(uint i)
        {
            return i < ExportMap.Count ? ExportMap[(int)i].ObjectName.DisplayValue : default;
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
            return PackageFileSummary.PackageFlags.HasFlag(EPackageFlags.PKG_FilterEditorOnly);
        }

        public bool HasUnversionedProperties()
        {
            return PackageFileSummary.PackageFlags.HasFlag(EPackageFlags.PKG_UnversionedProperties);
        }

        public bool HasCooked()
        {
            return PackageFileSummary.PackageFlags.HasFlag(EPackageFlags.PKG_Cooked);
        }
    }
}
