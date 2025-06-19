namespace AssetTool
{
    [JsonAsset("RuntimePartitionLevelStreaming")]
    public class URuntimePartitionLevelStreaming : URuntimePartition
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}