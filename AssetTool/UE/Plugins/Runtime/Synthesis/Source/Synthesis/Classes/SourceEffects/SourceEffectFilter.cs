namespace AssetTool
{
    [JsonAsset("SourceEffectFilterPreset")]
    public class USourceEffectFilterPreset : USoundEffectSourcePreset
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}