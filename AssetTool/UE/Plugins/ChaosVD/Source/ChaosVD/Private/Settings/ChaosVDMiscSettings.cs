namespace AssetTool
{
    [JsonAsset("ChaosVDMiscSettings")]
    public class UChaosVDMiscSettings : UChaosVDSettingsObjectBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}