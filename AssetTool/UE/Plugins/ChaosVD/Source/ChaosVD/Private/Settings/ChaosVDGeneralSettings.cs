namespace AssetTool
{
    [JsonAsset("ChaosVDGeneralSettings")]
    public class UChaosVDGeneralSettings : UChaosVDSettingsObjectBase
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}