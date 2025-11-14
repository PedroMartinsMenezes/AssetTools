namespace AssetTool
{
    [JsonAsset("RuntimePartitionLevelStreaming")]
    public class URuntimePartitionLevelStreaming : URuntimePartition
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}