namespace AssetTool
{
    [JsonAsset("SourceEffectMotionFilterPreset")]
    public class USourceEffectMotionFilterPreset : USoundEffectSourcePreset
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}