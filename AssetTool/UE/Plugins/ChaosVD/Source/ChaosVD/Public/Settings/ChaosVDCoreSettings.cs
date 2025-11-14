namespace AssetTool
{
    [JsonAsset("ChaosVDSettingsObjectsOuter")]
    public class UChaosVDSettingsObjectsOuter : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("ChaosVDSettingsObjectBase")]
    public class UChaosVDSettingsObjectBase : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("ChaosVDVisualizationSettingsObjectBase")]
    public class UChaosVDVisualizationSettingsObjectBase : UChaosVDSettingsObjectBase
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("ChaosVDCoreSettings")]
    public class UChaosVDCoreSettings : UChaosVDSettingsObjectBase
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}