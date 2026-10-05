namespace AssetTool
{
    [TransferableStruct("WorldPartitionActorFilter")]
    public class FWorldPartitionActorFilter : ITransferable
    {
        public int DataLayerFilterCount;
        public List<FString> AssetPathStr;
        public List<FSoftObjectPath> AssetPath;
        public List<TBool> bIncluded;
        public int ChildFilterCount;
        public List<FGuid> ActorGuid;
        public List<FWorldPartitionActorFilter> ChildFilter;

        [Location("bool FWorldPartitionActorFilter::Serialize(FArchive& Ar)")]
        public ITransferable Move(Transfer transfer)
        {
            transfer.Move(ref DataLayerFilterCount);

            transfer.Resize(ref bIncluded, DataLayerFilterCount);

            for (int i = 0; i < DataLayerFilterCount; ++i)
            {
                if (!transfer.Supports.WorldPartitionActorDescSerializeSoftObjectPathSupport || transfer.Supports.WorldPartitionActorFilterStringAssetPath)
                {
                    transfer.Resize(ref AssetPathStr, DataLayerFilterCount);
                    AssetPathStr[i].Move(transfer);
                }
                else
                {
                    transfer.Resize(ref AssetPath, DataLayerFilterCount);
                    AssetPath[i].Move(transfer);
                }
                bIncluded[i].Move(transfer);
            }

            transfer.Move(ref ChildFilterCount);
            transfer.Resize(ref ActorGuid, ChildFilterCount);
            transfer.Resize(ref ChildFilter, ChildFilterCount);

            for (int i = 0; i < ChildFilterCount; ++i)
            {
                ActorGuid[i].Move(transfer);
                ChildFilter[i].Move(transfer);
            }

            return this;
        }
    }
}