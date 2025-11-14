namespace AssetTool
{
    [JsonAsset("MassMovableVisualizationTrait")]
    public class UMassMovableVisualizationTrait : UMassVisualizationTrait
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}