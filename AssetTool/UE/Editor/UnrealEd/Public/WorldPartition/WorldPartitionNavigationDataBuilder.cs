namespace AssetTool
{
    [JsonAsset("WorldPartitionNavigationDataBuilder")]
    public class UWorldPartitionNavigationDataBuilder : UWorldPartitionBuilder
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}