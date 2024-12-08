namespace AssetTool
{
    [JsonAsset("WorldPartitionStreamingPolicy")]
    public class UWorldPartitionStreamingPolicy : UObject
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}