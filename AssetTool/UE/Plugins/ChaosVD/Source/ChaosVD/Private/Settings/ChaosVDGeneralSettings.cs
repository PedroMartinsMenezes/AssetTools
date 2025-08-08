namespace AssetTool
{
    [JsonAsset("ChaosVDGeneralSettings")]
    public class UChaosVDGeneralSettings : UChaosVDSettingsObjectBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}