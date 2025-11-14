namespace AssetTool
{
    [JsonAsset("WorldPartitionLevelStreamingPolicy")]
    public class UWorldPartitionLevelStreamingPolicy : UWorldPartitionStreamingPolicy
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}