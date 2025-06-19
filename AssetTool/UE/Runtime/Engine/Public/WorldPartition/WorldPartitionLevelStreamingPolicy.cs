namespace AssetTool
{
    [JsonAsset("WorldPartitionLevelStreamingPolicy")]
    public class UWorldPartitionLevelStreamingPolicy : UWorldPartitionStreamingPolicy
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}