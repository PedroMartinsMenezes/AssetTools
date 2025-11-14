namespace AssetTool
{
    [JsonAsset("SourceEffectEQPreset")]
    public class USourceEffectEQPreset : USoundEffectSourcePreset
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}