namespace AssetTool
{
    [JsonAsset("ResonanceAudioReverbPluginPreset")]
    public class UResonanceAudioReverbPluginPreset : USoundEffectSubmixPreset
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}