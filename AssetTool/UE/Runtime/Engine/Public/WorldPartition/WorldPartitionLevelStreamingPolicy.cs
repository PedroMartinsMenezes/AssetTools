namespace AssetTool
{
    [JsonAsset("WorldPartitionLevelStreamingPolicy")]
    public class UWorldPartitionLevelStreamingPolicy : UWorldPartitionStreamingPolicy
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}