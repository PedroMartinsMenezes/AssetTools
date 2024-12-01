namespace AssetTool
{
    [JsonAsset("SoundEffectSourcePreset")]
    public class USoundEffectSourcePreset : USoundEffectPreset
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("SoundEffectSourcePresetChain")]
    public class USoundEffectSourcePresetChain : UObject
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}