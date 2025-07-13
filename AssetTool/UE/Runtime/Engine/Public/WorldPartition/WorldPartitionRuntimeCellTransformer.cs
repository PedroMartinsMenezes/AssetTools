namespace AssetTool
{
    [JsonAsset("WorldPartitionRuntimeCellTransformer")]
    public class UWorldPartitionRuntimeCellTransformer : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}