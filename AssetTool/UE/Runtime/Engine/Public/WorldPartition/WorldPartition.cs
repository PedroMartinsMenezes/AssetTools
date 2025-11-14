namespace AssetTool
{
    [JsonAsset("WorldPartition")]
    public class UWorldPartition : UObject
    {
        public bool bCooked;

        public override ITransferable Move(Transfer transfer)
        {
            base.Move(transfer);
            if (transfer.Supports.WorldPartitionSerializeStreamingPolicyOnCook)
            {
                transfer.Move(ref bCooked);
            }
            return this;
        }
    }
}