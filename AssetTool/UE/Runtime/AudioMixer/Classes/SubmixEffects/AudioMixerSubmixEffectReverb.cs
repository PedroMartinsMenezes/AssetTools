namespace AssetTool
{
    [JsonAsset("SubmixEffectReverbPreset")]
    public class USubmixEffectReverbPreset : USoundEffectSubmixPreset
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}