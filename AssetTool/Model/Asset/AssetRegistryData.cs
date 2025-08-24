namespace AssetTool
{
    public class AssetRegistryData : ITransferible
    {
        public int ExportCount;
        public FDeserializePackageData DeserializePackageData;
        public List<FDeserializeObjectPackageData> ObjectPackageData;
        public FReadPackageDataDependenciesArgs Args;

        public AssetRegistryData() { }

        public AssetRegistryData(int exportCount)
        {
            ExportCount = exportCount;
        }

        [Location("bool FPackageReader::ReadAssetRegistryData(TArray<FAssetData*>& AssetDataList, bool& bOutIsCookedWithoutAssetData)")]
        public ITransferible Move(Transfer transfer)
        {
            ReadPackageDataMain(transfer);
            ReadDependencyData(transfer);
            return this;
        }

        [Location("bool ReadPackageDataMain(FArchive& BinaryArchive, const FString& PackageName, const FPackageFileSummary& PackageFileSummary, int64& OutDependencyDataOffset")]
        public void ReadPackageDataMain(Transfer transfer)
        {
            if (ExportCount > 0 || DeserializePackageData is { })
            {
                transfer.Move(ref DeserializePackageData);
                transfer.Move(ref ObjectPackageData, DeserializePackageData.ObjectCount, (x) =>
                {
                    x.Move(transfer);
                    transfer.Move(ref x.TagsAndValues, x.TagCount);
                });
            }
        }

        [Location("bool FPackageReader::ReadDependencyData(FPackageDependencyData& OutDependencyData, EReadOptions Options)")]
        private void ReadDependencyData(Transfer transfer)
        {
            SerializeAssetRegistryDependencyData(transfer);
        }

        [Location("bool FPackageReader::SerializeAssetRegistryDependencyData(TBitArray<>& OutImportUsedInGame,")]
        private void SerializeAssetRegistryDependencyData(Transfer transfer)
        {
            if (DeserializePackageData is { })
            {
                Args ??= new();
                Args.AssetRegistryDependencyDataOffset = DeserializePackageData.DependencyDataOffset;
                ReadPackageDataDependencies(transfer);
            }
        }

        [Location("bool ReadPackageDataDependencies(FReadPackageDataDependenciesArgs& Args)")]
        private void ReadPackageDataDependencies(Transfer transfer)
        {
            if (Args.AssetRegistryDependencyDataOffset != -1)
            {
                if (transfer.IsReading && transfer.Position != Args.AssetRegistryDependencyDataOffset)
                    throw new InvalidOperationException();

                transfer.Move(ref Args.ImportUsedInGame);
                transfer.Move(ref Args.SoftPackageUsedInGame);
                if (transfer.Supports.ASSETREGISTRY_PACKAGEBUILDDEPENDENCIES)
                {
                    transfer.Move(ref Args.ExtraPackageDependenciesAsIntegers);
                }
            }
        }
    }

    public class FReadPackageDataDependenciesArgs
    {
        public int64 AssetRegistryDependencyDataOffset = -1;
        public TBitArray ImportUsedInGame = new();
        public TBitArray SoftPackageUsedInGame = new();
        public List<TTuple<FName, TUInt32>> ExtraPackageDependenciesAsIntegers;
    }

    #region FDeserializePackageData
    public class FDeserializePackageData : ITransferible
    {
        public Int64 DependencyDataOffset = -1;
        public int32 ObjectCount;//[JsonIgnore] 

        [Location("bool FDeserializePackageData::DoSerialize(FArchive& BinaryArchive, const FPackageFileSummary& PackageFileSummary")]
        public ITransferible Move(Transfer transfer)
        {
            bool bPreDependencyFormat = !transfer.Supports.VER_UE4_ASSETREGISTRY_DEPENDENCYFLAGS || transfer.GlobalObjects.IsFilterEditorOnly();
            if (!bPreDependencyFormat)
            {
                transfer.Move(ref DependencyDataOffset);
            }
            transfer.Move(ref ObjectCount);
            return this;
        }
    }

    public class FDeserializeObjectPackageData : ITransferible
    {
        public FString ObjectPath;
        public FString ObjectClassName;
        public int32 TagCount;//[JsonIgnore] 
        public Dictionary<FString, FString> TagsAndValues;

        [Location("bool FDeserializeObjectPackageData::DoSerialize(FArchive& BinaryArchive")]
        public ITransferible Move(Transfer transfer)
        {
            transfer.Move(ref ObjectPath);
            transfer.Move(ref ObjectClassName);
            transfer.Move(ref TagCount);
            return this;
        }
    }
    #endregion
}
