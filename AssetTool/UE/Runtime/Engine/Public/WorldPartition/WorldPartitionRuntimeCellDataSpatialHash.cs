namespace AssetTool
{
    [JsonAsset("WorldPartitionRuntimeCellDataSpatialHash")]
    public class UWorldPartitionRuntimeCellDataSpatialHash : UWorldPartitionRuntimeCellData
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}