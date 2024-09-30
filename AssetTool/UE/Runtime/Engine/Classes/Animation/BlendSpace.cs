namespace AssetTool
{
    [Location("void UBlendSpace::Serialize(FArchive& Ar)")]
    public class UBlendSpace : UAnimationAsset
    {
        public new const string TypeName = "BlendSpace";

        public override UObject Move(Transfer transfer)
        {
            base.Move(transfer);
            return this;
        }
    }
}