namespace AssetTool
{
    [JsonAsset("InstancedActorsVisualizationTrait")]
    public class UInstancedActorsVisualizationTrait : UMassStationaryDistanceVisualizationTrait
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}