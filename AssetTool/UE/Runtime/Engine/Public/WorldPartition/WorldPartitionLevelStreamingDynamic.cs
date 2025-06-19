namespace AssetTool
{
    [JsonAsset("WorldPartitionLevelStreamingDynamic")]
    public class UWorldPartitionLevelStreamingDynamic : ULevelStreamingDynamic
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}