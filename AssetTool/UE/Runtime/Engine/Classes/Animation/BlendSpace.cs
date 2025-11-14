namespace AssetTool
{
    [JsonAsset("BlendSpace")]
    public class UBlendSpace : UAnimationAsset
    {
        [Location("void UBlendSpace::Serialize(FArchive& Ar)")]
        public override ITransferable Move(Transfer transfer)
        {
            base.Move(transfer);
            return this;
        }
    }

    [JsonAsset("AnalysisProperties")]
    public class UAnalysisProperties : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            base.Move(transfer);
            return this;
        }
    }
}