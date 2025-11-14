namespace AssetTool
{
    [JsonAsset("MassStationaryVisualizationTrait")]
    public class UMassStationaryVisualizationTrait : UMassVisualizationTrait
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}