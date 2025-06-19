namespace AssetTool
{
    [JsonAsset("WorldPartitionStreamingPolicy")]
    public class UWorldPartitionStreamingPolicy : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}