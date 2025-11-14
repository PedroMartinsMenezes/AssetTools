namespace AssetTool
{
    [JsonAsset("PartitionActor")]
    public class APartitionActor : AActor
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}