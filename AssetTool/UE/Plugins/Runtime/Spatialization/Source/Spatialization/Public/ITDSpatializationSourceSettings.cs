namespace AssetTool
{
    [JsonAsset("ITDSpatializationSourceSettings")]
    public class UITDSpatializationSourceSettings : USpatializationPluginSourceSettingsBase
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}