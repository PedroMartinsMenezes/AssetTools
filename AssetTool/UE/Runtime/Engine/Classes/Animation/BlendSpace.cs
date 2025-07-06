namespace AssetTool
{
    [JsonAsset("BlendSpace")]
    public class UBlendSpace : UAnimationAsset
    {
        [Location("void UBlendSpace::Serialize(FArchive& Ar)")]
        public override ITransferible Move(Transfer transfer)
        {
            base.Move(transfer);
            return this;
        }
    }

    [JsonAsset("AnalysisProperties")]
    public class UAnalysisProperties : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            base.Move(transfer);
            return this;
        }
    }
}