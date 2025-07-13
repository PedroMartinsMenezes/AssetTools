namespace AssetTool
{
    [JsonAsset("MassStationaryDistanceVisualizationTrait")]
    public class UMassStationaryDistanceVisualizationTrait : UMassDistanceVisualizationTrait
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}