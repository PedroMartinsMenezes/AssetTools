namespace AssetTool
{
    [JsonAsset("WorldPartitionRuntimeCellDataHashSet")]
    public class UWorldPartitionRuntimeCellDataHashSet : UWorldPartitionRuntimeCellData
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}