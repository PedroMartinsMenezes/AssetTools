namespace AssetTool
{
    [JsonAsset("ResonanceAudioSpatializationSourceSettings")]
    public class UResonanceAudioSpatializationSourceSettings : USpatializationPluginSourceSettingsBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}