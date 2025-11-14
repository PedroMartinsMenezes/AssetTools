namespace AssetTool
{
    [JsonAsset("SubmixEffectDelayStatics")]
    public class USubmixEffectDelayStatics : UBlueprintFunctionLibrary
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("SubmixEffectDelayPreset")]
    public class USubmixEffectDelayPreset : USoundEffectSubmixPreset
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}