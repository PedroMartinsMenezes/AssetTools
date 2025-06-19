namespace AssetTool
{
    [JsonAsset("SoundEffectSourcePreset")]
    public class USoundEffectSourcePreset : USoundEffectPreset
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("SoundEffectSourcePresetChain")]
    public class USoundEffectSourcePresetChain : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}