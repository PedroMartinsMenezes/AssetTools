namespace AssetTool
{
    [JsonAsset("SourceEffectPannerPreset")]
    public class USourceEffectPannerPreset : USoundEffectSourcePreset
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}