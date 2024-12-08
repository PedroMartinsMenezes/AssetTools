namespace AssetTool
{
    [JsonAsset("WorldPartitionRuntimeCellDataSpatialHash")]
    public class UWorldPartitionRuntimeCellDataSpatialHash : UWorldPartitionRuntimeCellData
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}