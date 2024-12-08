namespace AssetTool
{
    [JsonAsset("WorldPartitionLevelStreamingDynamic")]
    public class UWorldPartitionLevelStreamingDynamic : ULevelStreamingDynamic
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}