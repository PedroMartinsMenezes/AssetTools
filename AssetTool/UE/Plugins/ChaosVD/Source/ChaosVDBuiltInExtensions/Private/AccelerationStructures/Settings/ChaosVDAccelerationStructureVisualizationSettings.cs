namespace AssetTool
{
    [JsonAsset("ChaosVDAccelerationStructureVisualizationSettings")]
    public class UChaosVDAccelerationStructureVisualizationSettings : UChaosVDVisualizationSettingsObjectBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}