namespace AssetTool
{
    [JsonAsset("RuntimePartitionPersistent")]
    public class URuntimePartitionPersistent : URuntimePartition
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}