namespace AssetTool
{
    [JsonAsset("RuntimePartitionPersistent")]
    public class URuntimePartitionPersistent : URuntimePartition
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}