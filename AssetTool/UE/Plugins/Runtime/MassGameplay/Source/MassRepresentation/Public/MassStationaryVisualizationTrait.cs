namespace AssetTool
{
    [JsonAsset("MassStationaryVisualizationTrait")]
    public class UMassStationaryVisualizationTrait : UMassVisualizationTrait
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}