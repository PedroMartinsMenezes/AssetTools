namespace AssetTool
{
    [JsonAsset("WorldPartitionStreamingPolicy")]
    public class UWorldPartitionStreamingPolicy : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}