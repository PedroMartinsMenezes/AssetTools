namespace AssetTool
{
    [JsonAsset("PCGPartitionActor")]
    public class APCGPartitionActor : APartitionActor
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}