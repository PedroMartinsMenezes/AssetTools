namespace AssetTool
{
    [JsonAsset("AmbisonicsEncodingSettings")]
    public class UAmbisonicsEncodingSettings : USoundfieldEncodingSettingsBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}