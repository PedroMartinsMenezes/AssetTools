namespace AssetTool
{
    [JsonAsset("ChaosVDCollisionDataVisualizationSettings")]
    public class UChaosVDCollisionDataVisualizationSettings : UChaosVDVisualizationSettingsObjectBase
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}