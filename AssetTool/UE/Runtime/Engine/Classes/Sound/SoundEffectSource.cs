namespace AssetTool
{
    [JsonAsset("SoundEffectSourcePreset")]
    public class USoundEffectSourcePreset : USoundEffectPreset
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("SoundEffectSourcePresetChain")]
    public class USoundEffectSourcePresetChain : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}