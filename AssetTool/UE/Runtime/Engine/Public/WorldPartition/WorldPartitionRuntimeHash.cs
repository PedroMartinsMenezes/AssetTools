namespace AssetTool
{
    [JsonAsset("RuntimeHashExternalStreamingObjectBase")]
    public class URuntimeHashExternalStreamingObjectBase : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("WorldPartitionRuntimeHash")]
    public class UWorldPartitionRuntimeHash : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}