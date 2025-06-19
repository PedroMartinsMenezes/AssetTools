namespace AssetTool
{
    [JsonAsset("RuntimeHashSetExternalStreamingObject")]
    public class URuntimeHashSetExternalStreamingObject : URuntimeHashExternalStreamingObjectBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("WorldPartitionRuntimeHashSet")]
    public class UWorldPartitionRuntimeHashSet : UWorldPartitionRuntimeHash
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}