namespace AssetTool
{
    [JsonAsset("HarmonixPluginSettings")]
    public class UHarmonixPluginSettings : UDeveloperSettings
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}