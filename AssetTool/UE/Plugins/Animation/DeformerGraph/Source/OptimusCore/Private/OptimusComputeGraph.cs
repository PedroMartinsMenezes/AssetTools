namespace AssetTool
{
    [JsonAsset("OptimusComputeGraph")]
    public class UOptimusComputeGraph : UComputeGraph
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}