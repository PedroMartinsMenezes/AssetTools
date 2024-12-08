namespace AssetTool
{
    [JsonAsset("RuntimeHashExternalStreamingObjectBase")]
    public class URuntimeHashExternalStreamingObjectBase : UObject
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("WorldPartitionRuntimeHash")]
    public class UWorldPartitionRuntimeHash : UObject
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}