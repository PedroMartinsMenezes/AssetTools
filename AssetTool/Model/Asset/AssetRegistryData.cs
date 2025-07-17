namespace AssetTool
{
    public class AssetRegistryData : Transferible<AssetRegistryData>
    {
        public int ExportCount;
        public FDeserializePackageData DeserializePackageData;
        public FPackageDependencyData PackageDependencyData;

        public AssetRegistryData() { }

        public AssetRegistryData(int exportCount)
        {
            ExportCount = exportCount;
        }

        public override ITransferible Move(Transfer transfer)
        {
            if (ExportCount > 0 || DeserializePackageData is { })
            {
                transfer.Move(ref DeserializePackageData);

                if (DeserializePackageData.DependencyDataOffset != -1)
                {
                    transfer.Move(ref PackageDependencyData);
                }
            }
            return this;
        }
    }

    #region FDeserializePackageData
    public class FDeserializePackageData : ITransferible
    {
        public Int64 DependencyDataOffset = -1;
        public List<FDeserializeObjectPackageData> ObjectPackageData;

        [Location("bool FDeserializePackageData::DoSerialize(FArchive& BinaryArchive, const FPackageFileSummary& PackageFileSummary")]
        public ITransferible Move(Transfer transfer)
        {
            if (!PreDependencyFormat(transfer))
            {
                transfer.Move(ref DependencyDataOffset);
            }
            transfer.Move(ref ObjectPackageData);
            return this;
        }

        private static bool PreDependencyFormat(Transfer transfer)
        {
            return
            transfer.GlobalObjects.PackageFileSummary.FileVersionUE.FileVersionUE4 < (int)EUnrealEngineObjectUE4Version.VER_UE4_ASSETREGISTRY_DEPENDENCYFLAGS
            ||
            (transfer.GlobalObjects.PackageFileSummary.PackageFlags & EPackageFlags.PKG_FilterEditorOnly) > 0;
        }
    }

    public class FDeserializeObjectPackageData : ITransferible
    {
        public FString ObjectPath;
        public FString ObjectClassName;
        public Dictionary<FString, FString> TagsAndValues;

        [Location("bool FDeserializeObjectPackageData::DoSerialize(FArchive& BinaryArchive")]
        public ITransferible Move(Transfer transfer)
        {
            transfer.Move(ref ObjectPath);
            transfer.Move(ref ObjectClassName);
            transfer.Move(ref TagsAndValues);
            return this;
        }
    }
    #endregion

    public class FPackageDependencyData : ITransferible
    {
        public TBitArray OutImportUsedInGame;
        public TBitArray OutSoftPackageUsedInGame;

        public ITransferible Move(Transfer transfer)
        {
            transfer.Move(ref OutImportUsedInGame);
            transfer.Move(ref OutSoftPackageUsedInGame);
            return this;
        }
    }
}
