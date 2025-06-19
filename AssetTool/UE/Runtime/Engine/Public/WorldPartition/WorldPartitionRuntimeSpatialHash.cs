namespace AssetTool
{
    [JsonAsset("SpatialHashRuntimeGridInfo")]
    public class ASpatialHashRuntimeGridInfo : AInfo
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("RuntimeSpatialHashExternalStreamingObject")]
    public class URuntimeSpatialHashExternalStreamingObject : URuntimeHashExternalStreamingObjectBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("WorldPartitionRuntimeSpatialHash")]
    public class UWorldPartitionRuntimeSpatialHash : UWorldPartitionRuntimeHash
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}