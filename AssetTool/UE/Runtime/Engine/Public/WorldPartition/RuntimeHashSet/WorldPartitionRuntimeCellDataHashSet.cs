namespace AssetTool
{
    [JsonAsset("WorldPartitionRuntimeCellDataHashSet")]
    public class UWorldPartitionRuntimeCellDataHashSet : UWorldPartitionRuntimeCellData
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}