namespace AssetTool
{
    [JsonAsset("MassCrowdVisualizationTrait")]
    public class UMassCrowdVisualizationTrait : UMassVisualizationTrait
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}