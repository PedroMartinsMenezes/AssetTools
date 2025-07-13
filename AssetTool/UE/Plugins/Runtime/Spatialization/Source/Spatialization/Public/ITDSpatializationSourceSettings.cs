namespace AssetTool
{
    [JsonAsset("ITDSpatializationSourceSettings")]
    public class UITDSpatializationSourceSettings : USpatializationPluginSourceSettingsBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}