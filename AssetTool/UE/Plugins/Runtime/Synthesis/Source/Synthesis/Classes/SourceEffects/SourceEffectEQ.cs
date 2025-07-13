namespace AssetTool
{
    [JsonAsset("SourceEffectEQPreset")]
    public class USourceEffectEQPreset : USoundEffectSourcePreset
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}