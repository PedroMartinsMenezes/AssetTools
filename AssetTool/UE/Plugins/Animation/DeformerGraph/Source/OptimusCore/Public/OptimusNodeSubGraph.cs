namespace AssetTool
{
    [JsonAsset("OptimusNodeSubGraph")]
    public class UOptimusNodeSubGraph : UOptimusNodeGraph
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}