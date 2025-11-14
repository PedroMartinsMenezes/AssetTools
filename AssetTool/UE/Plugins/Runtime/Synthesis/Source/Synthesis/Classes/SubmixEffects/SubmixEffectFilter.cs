namespace AssetTool
{
    [JsonAsset("SubmixEffectFilterPreset")]
    public class USubmixEffectFilterPreset : USoundEffectSubmixPreset
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}