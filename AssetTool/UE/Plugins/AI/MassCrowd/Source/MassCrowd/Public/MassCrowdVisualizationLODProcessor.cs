namespace AssetTool
{
    [JsonAsset("MassCrowdVisualizationLODProcessor")]
    public class UMassCrowdVisualizationLODProcessor : UMassVisualizationLODProcessor
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MassCrowdLODCollectorProcessor")]
    public class UMassCrowdLODCollectorProcessor : UMassLODCollectorProcessor
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}