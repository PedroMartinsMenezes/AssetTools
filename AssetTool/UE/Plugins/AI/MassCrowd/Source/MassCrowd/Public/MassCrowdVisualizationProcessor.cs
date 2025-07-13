namespace AssetTool
{
    [JsonAsset("MassCrowdVisualizationProcessor")]
    public class UMassCrowdVisualizationProcessor : UMassVisualizationProcessor
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MassDebugCrowdVisualizationProcessor")]
    public class UMassDebugCrowdVisualizationProcessor : UMassProcessor
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}