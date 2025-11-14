namespace AssetTool
{
    [JsonAsset("HarmonixPluginSettings")]
    public class UHarmonixPluginSettings : UDeveloperSettings
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}