namespace AssetTool
{
    [JsonAsset("PCGWorldPartitionBuilder")]
    public class UPCGWorldPartitionBuilder : UWorldPartitionBuilder
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}