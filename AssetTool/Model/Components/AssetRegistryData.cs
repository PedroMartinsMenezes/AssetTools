namespace AssetTool
{
    public class AssetRegistryData : ITransferible<AssetRegistryData>
    {
        public FDeserializePackageData DeserializePackageData = new();
        public FPackageDependencyData PackageDependencyData = new();

        public override void Move(Transfer transfer)
        {
            DeserializePackageData.Move(transfer);
            if (DeserializePackageData.DependencyDataOffset != -1)
            {
                PackageDependencyData.Move(transfer);
            }
        }
    }

    #region FDeserializePackageData
    [Location("bool FDeserializePackageData::DoSerialize(FArchive& BinaryArchive, const FPackageFileSummary& PackageFileSummary")]
    public class FDeserializePackageData
    {
        public Int64 DependencyDataOffset = -1;
        public Int32 ObjectCount;
        public List<FDeserializeObjectPackageData> ObjectPackageData = [];

        public void Move(Transfer transfer)
        {
            if (!PreDependencyFormat())
            {
                transfer.Move(ref DependencyDataOffset);
            }
            transfer.Move(ref ObjectCount);

            ObjectPackageData.Resize(transfer, ObjectCount);
            ObjectPackageData.ForEach(x => x.Move(transfer));
        }

        private static bool PreDependencyFormat()
        {
            return
            GlobalObjects.PackageFileSummary.FileVersionUE.FileVersionUE4 < (int)EUnrealEngineObjectUE4Version.VER_UE4_ASSETREGISTRY_DEPENDENCYFLAGS
            ||
            (GlobalObjects.PackageFileSummary.PackageFlags & (uint)EPackageFlags.PKG_FilterEditorOnly) > 0;
        }
    }

    [Location("bool FDeserializeObjectPackageData::DoSerialize(FArchive& BinaryArchive")]
    public class FDeserializeObjectPackageData
    {
        public FString ObjectPath = new();
        public FString ObjectClassName = new();
        public Dictionary<FString, FString> TagsAndValues = new();

        public void Move(Transfer transfer)
        {
            transfer.Move(ref ObjectPath);
            transfer.Move(ref ObjectClassName);
            TagsAndValues.Move(transfer, (key) => transfer.Move(key), (value) => transfer.Move(value));
        }
    }

    public class FDeserializeTagData
    {
        public FString Key = new();
        public FString Value = new();

        public void Move(Transfer transfer)
        {
            transfer.Move(Key);
            transfer.Move(Value);
        }
    }
    #endregion

    public class FPackageDependencyData
    {
        public TBitArray OutImportUsedInGame = new();
        public TBitArray OutSoftPackageUsedInGame = new();

        public void Move(Transfer transfer)
        {
            OutImportUsedInGame.Move(transfer);
            OutSoftPackageUsedInGame.Move(transfer);
        }
    }
}
