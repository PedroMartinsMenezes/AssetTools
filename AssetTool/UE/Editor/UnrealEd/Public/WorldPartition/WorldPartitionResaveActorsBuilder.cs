namespace AssetTool
{
    [JsonAsset("WorldPartitionResaveActorsBuilder")]
    public class UWorldPartitionResaveActorsBuilder : UWorldPartitionBuilder
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}