namespace AssetTool
{
    [JsonAsset("BlendSpace")]
    public class UBlendSpace : UAnimationAsset
    {
        [Location("void UBlendSpace::Serialize(FArchive& Ar)")]
        public override UObject Move(Transfer transfer)
        {
            base.Move(transfer);
            return this;
        }
    }
}