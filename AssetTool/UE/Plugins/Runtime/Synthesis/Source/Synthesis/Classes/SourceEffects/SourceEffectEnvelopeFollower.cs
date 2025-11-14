namespace AssetTool
{
    [JsonAsset("EnvelopeFollowerListener")]
    public class UEnvelopeFollowerListener : UActorComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("SourceEffectEnvelopeFollowerPreset")]
    public class USourceEffectEnvelopeFollowerPreset : USoundEffectSourcePreset
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}