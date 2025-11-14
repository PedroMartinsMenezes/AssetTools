namespace AssetTool
{
    [JsonAsset("ResonanceAudioSpatializationSourceSettings")]
    public class UResonanceAudioSpatializationSourceSettings : USpatializationPluginSourceSettingsBase
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}