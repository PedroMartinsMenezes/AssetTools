namespace AssetTool
{
    [JsonAsset("MassStationaryDistanceVisualizationTrait")]
    public class UMassStationaryDistanceVisualizationTrait : UMassDistanceVisualizationTrait
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}