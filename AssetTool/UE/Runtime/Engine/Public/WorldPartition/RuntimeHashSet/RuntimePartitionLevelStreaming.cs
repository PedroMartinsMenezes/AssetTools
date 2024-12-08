namespace AssetTool
{
    [JsonAsset("RuntimePartitionLevelStreaming")]
    public class URuntimePartitionLevelStreaming : URuntimePartition
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}