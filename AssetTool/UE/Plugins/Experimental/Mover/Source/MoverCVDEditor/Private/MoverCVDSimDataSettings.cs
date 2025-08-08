namespace AssetTool
{
    [JsonAsset("MoverCVDSimDataSettings")]
    public class UMoverCVDSimDataSettings : UChaosVDVisualizationSettingsObjectBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}