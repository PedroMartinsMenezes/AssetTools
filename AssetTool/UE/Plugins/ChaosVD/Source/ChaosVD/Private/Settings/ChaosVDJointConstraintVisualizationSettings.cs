namespace AssetTool
{
    [JsonAsset("ChaosVDJointConstraintsVisualizationSettings")]
    public class UChaosVDJointConstraintsVisualizationSettings : UChaosVDVisualizationSettingsObjectBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}