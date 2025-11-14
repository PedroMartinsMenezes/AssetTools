namespace AssetTool
{
    [JsonAsset("SourceEffectFilterPreset")]
    public class USourceEffectFilterPreset : USoundEffectSourcePreset
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}