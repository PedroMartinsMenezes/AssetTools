namespace AssetTool
{
    [JsonAsset("RuntimeHashSetExternalStreamingObject")]
    public class URuntimeHashSetExternalStreamingObject : URuntimeHashExternalStreamingObjectBase
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("WorldPartitionRuntimeHashSet")]
    public class UWorldPartitionRuntimeHashSet : UWorldPartitionRuntimeHash
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}