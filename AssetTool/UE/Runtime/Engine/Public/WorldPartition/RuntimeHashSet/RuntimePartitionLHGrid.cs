namespace AssetTool
{
    [JsonAsset("RuntimePartitionLHGrid")]
    public class URuntimePartitionLHGrid : URuntimePartition
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}