namespace AssetTool
{
    public class UBlendSpace : UAnimationAsset
    {
        public new const string TypeName = "BlendSpace";

        [Location("void UBlendSpace::Serialize(FArchive& Ar)")]
        public override UObject Move(Transfer transfer)
        {
            base.Move(transfer);
            return this;
        }
    }
}