namespace AssetTool
{
    [JsonAsset("AmbisonicsEncodingSettings")]
    public class UAmbisonicsEncodingSettings : USoundfieldEncodingSettingsBase
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}