namespace AssetTool
{
    [JsonAsset("PCGWorldPartitionBuilder")]
    public class UPCGWorldPartitionBuilder : UWorldPartitionBuilder
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}