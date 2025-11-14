namespace AssetTool
{
    [JsonAsset("ISMPartitionActor")]
    public class AISMPartitionActor : APartitionActor
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}