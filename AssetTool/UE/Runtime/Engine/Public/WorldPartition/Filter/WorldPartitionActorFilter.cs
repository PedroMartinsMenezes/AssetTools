namespace AssetTool
{
    [TransferibleStruct("WorldPartitionActorFilter")]
    public class FWorldPartitionActorFilter : ITransferible
    {
        public uint32 DataLayerFilterCount;
        public List<FString> AssetPathStr;
        public List<FSoftObjectPath> AssetPath;
        public List<FBool> bIncluded;
        public uint32 ChildFilterCount;
        public List<FGuid> ActorGuid;
        public List<FWorldPartitionActorFilter> ChildFilter;

        [Location("bool FWorldPartitionActorFilter::Serialize(FArchive& Ar)")]
        public ITransferible Move(Transfer transfer)
        {
            transfer.Move(ref DataLayerFilterCount);
            bIncluded = bIncluded.Resize(transfer, DataLayerFilterCount);

            for (int i = 0; i < DataLayerFilterCount; ++i)
            {
                if (!transfer.Supports.WorldPartitionActorDescSerializeSoftObjectPathSupport || transfer.Supports.WorldPartitionActorFilterStringAssetPath)
                {
                    AssetPathStr ??= AssetPathStr.Resize(transfer, DataLayerFilterCount);
                    AssetPathStr[i].Move(transfer);
                }
                else
                {
                    AssetPath ??= AssetPath.Resize(transfer, DataLayerFilterCount);
                    AssetPath[i].Move(transfer);
                }
                bIncluded[i].Move(transfer);
            }

            transfer.Move(ref ChildFilterCount);
            ActorGuid = ActorGuid.Resize(transfer, ChildFilterCount);
            ChildFilter = ChildFilter.Resize(transfer, ChildFilterCount);

            for (int i = 0; i < ChildFilterCount; ++i)
            {
                ActorGuid[i].Move(transfer);
                ChildFilter[i].Move(transfer);
            }

            return this;
        }
    }
}