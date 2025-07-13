namespace AssetTool
{
    [JsonAsset("RuntimePartitionLHGrid")]
    public class URuntimePartitionLHGrid : URuntimePartition
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}