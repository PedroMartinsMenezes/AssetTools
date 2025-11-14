namespace AssetTool
{
    [JsonAsset("SpatialHashRuntimeGridInfo")]
    public class ASpatialHashRuntimeGridInfo : AInfo
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("RuntimeSpatialHashExternalStreamingObject")]
    public class URuntimeSpatialHashExternalStreamingObject : URuntimeHashExternalStreamingObjectBase
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("WorldPartitionRuntimeSpatialHash")]
    public class UWorldPartitionRuntimeSpatialHash : UWorldPartitionRuntimeHash
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}