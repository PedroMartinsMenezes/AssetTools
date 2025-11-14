namespace AssetTool
{
    [JsonAsset("MassCrowdVisualizationTrait")]
    public class UMassCrowdVisualizationTrait : UMassVisualizationTrait
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}