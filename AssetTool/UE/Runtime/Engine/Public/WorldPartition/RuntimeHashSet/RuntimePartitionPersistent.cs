namespace AssetTool
{
    [JsonAsset("RuntimePartitionPersistent")]
    public class URuntimePartitionPersistent : URuntimePartition
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}