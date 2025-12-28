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

            //Reading the recognized classes
            RecognizedClasses = "JsonAssetClasses.json".ReadJson<Dictionary<string, string>>();
        }

        #region Static Members

        /// <summary>
        /// List of UE classes containing the UCLASS attribute and the Serialize method translated to C#.
        /// The Key is the ClassName and the Value is the funtion that serializes de object.
        /// </summary>
        public static Dictionary<string, Action<Transfer, AssetObject>> AssetMovers { get; } = new();

        /// <summary>
        /// List of UE classes containing the UCLASS attribute but empty Serialize method. 
        /// The Key is the ClassName and the Value is the BaseClassName.
        /// </summary>
        public static Dictionary<string, string> RecognizedClasses { get; set; } = new();

        #endregion

        #region Dynamic Members

        public AssetObject CurrentObject { get; set; }

        public FPackageFileSummary PackageFileSummary { get; set; }

        public SoftObjectPathList SoftObjectPathList { get; set; }

        public ExportMap ExportMap { get; set; }

        public ImportMap ImportMap { get; set; }

        public HashSet<string> UnicodeStrings { get; set; } = [];

        public string FileName { get; set; }

        public int FileSize { get; set; }

        public long ExportEndOffset => ExportMap?.EndOffset ?? 0;

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
            return (int)PackageFileSummary.FileVersionUE.FileVersionUE4 >= (int)value;
        }

        public bool UESupport(EUnrealEngineObjectUE5Version value)
        {
            return (int)PackageFileSummary.FileVersionUE.FileVersionUE5 >= (int)value;
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

        public (int, int, string) GetTypeNameFromPackageIndex(int index)
        {
            (int exportIndex, int importIndex, string typeName) = (0, 0, null);
            if (index == 0)
            {
                return (exportIndex, importIndex, typeName);
            }
            else if (index < 0)
            {
                importIndex = index;
                index = -1 * index - 1;
                typeName = index < ImportMap.ObjectImports.Count ? ImportMap.ObjectImports[index].ObjectName.Value : null;
                return (exportIndex, importIndex, typeName);
            }
            else
            {
                exportIndex = index;
                index = index - 1;
                importIndex = ExportMap?.ObjectExports[index]?.ClassIndex?.Index ?? 0;
                while (importIndex > 0)
                {
                    importIndex = ExportMap.ObjectExports[importIndex - 1]?.ClassIndex?.Index ?? 0;
                }
                if (importIndex < 0)
                {
                    index = -1 * importIndex - 1;
                    typeName = index < ImportMap.ObjectImports.Count ? ImportMap.ObjectImports[index].ObjectName.Value : null;
                    return (exportIndex, importIndex, typeName);
                }
                else
                {
                    return (exportIndex, importIndex, typeName);
                }
            }
        }

        public static Action<Transfer, AssetObject> GetRecognizedMover(string typeName)
        {
            if (RecognizedClasses.TryGetValue(typeName, out string baseType))
            {
                Action<Transfer, AssetObject> moverFound;
                while (!AssetMovers.TryGetValue(baseType, out moverFound))
                {
                    baseType = RecognizedClasses[baseType];
                }
                return moverFound;
            }
            else
            {
                return null;
            }
        }

        public static string GetRecognizedBaseClass(string typeName)
        {
            if (RecognizedClasses.TryGetValue(typeName, out string baseType))
            {
                Action<Transfer, AssetObject> moverFound;
                while (!AssetMovers.TryGetValue(baseType, out moverFound))
                {
                    baseType = RecognizedClasses[baseType];
                }
                return baseType;
            }
            else
            {
                return null;
            }
        }
    }
}
