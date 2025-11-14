namespace AssetTool
{
    [JsonAsset("ChaosVDMiscSettings")]
    public class UChaosVDMiscSettings : UChaosVDSettingsObjectBase
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}