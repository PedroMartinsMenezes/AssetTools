namespace AssetTool
{
    [JsonAsset("ChaosVDCharacterConstraintsVisualizationSettings")]
    public class UChaosVDCharacterConstraintsVisualizationSettings : UChaosVDVisualizationSettingsObjectBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}