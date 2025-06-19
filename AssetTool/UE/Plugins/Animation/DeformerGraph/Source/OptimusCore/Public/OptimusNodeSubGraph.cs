namespace AssetTool
{
    [JsonAsset("OptimusNodeSubGraph")]
    public class UOptimusNodeSubGraph : UOptimusNodeGraph
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}