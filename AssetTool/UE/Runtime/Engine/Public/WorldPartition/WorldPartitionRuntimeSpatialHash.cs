namespace AssetTool
{
    [JsonAsset("SpatialHashRuntimeGridInfo")]
    public class ASpatialHashRuntimeGridInfo : AInfo
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("RuntimeSpatialHashExternalStreamingObject")]
    public class URuntimeSpatialHashExternalStreamingObject : URuntimeHashExternalStreamingObjectBase
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("WorldPartitionRuntimeSpatialHash")]
    public class UWorldPartitionRuntimeSpatialHash : UWorldPartitionRuntimeHash
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}