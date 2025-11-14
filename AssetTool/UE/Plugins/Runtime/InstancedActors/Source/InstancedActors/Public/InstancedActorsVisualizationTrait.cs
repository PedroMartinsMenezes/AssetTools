namespace AssetTool
{
    [JsonAsset("InstancedActorsVisualizationTrait")]
    public class UInstancedActorsVisualizationTrait : UMassStationaryDistanceVisualizationTrait
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}