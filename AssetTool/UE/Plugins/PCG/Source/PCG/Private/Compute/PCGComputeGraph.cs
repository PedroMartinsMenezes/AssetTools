namespace AssetTool
{
    [JsonAsset("PCGComputeGraph")]
    public class UPCGComputeGraph : UComputeGraph
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}