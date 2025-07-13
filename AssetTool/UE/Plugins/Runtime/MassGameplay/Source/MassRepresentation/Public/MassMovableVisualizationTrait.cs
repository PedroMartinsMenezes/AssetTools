namespace AssetTool
{
    [JsonAsset("MassMovableVisualizationTrait")]
    public class UMassMovableVisualizationTrait : UMassVisualizationTrait
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}