namespace AssetTool
{
    [JsonAsset("WorldPartitionRuntimeCellTransformer")]
    public class UWorldPartitionRuntimeCellTransformer : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}