namespace AssetTool
{
    [JsonAsset("MoverCVDSimDataSettings")]
    public class UMoverCVDSimDataSettings : UChaosVDVisualizationSettingsObjectBase
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}