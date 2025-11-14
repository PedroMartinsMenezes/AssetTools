namespace AssetTool
{
    [JsonAsset("PCGComputeGraph")]
    public class UPCGComputeGraph : UComputeGraph
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}