namespace AssetTool
{
    [JsonAsset("OptimusFunctionNodeGraph")]
    public class UOptimusFunctionNodeGraph : UOptimusNodeSubGraph
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}