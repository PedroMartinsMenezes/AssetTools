namespace AssetTool
{
    [JsonAsset("ChaosVDGenericDebugDrawSettings")]
    public class UChaosVDGenericDebugDrawSettings : UChaosVDVisualizationSettingsObjectBase
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}