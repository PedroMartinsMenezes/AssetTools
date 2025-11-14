namespace AssetTool
{
    [JsonAsset("PCGPartitionActor")]
    public class APCGPartitionActor : APartitionActor
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}