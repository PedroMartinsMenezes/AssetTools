namespace AssetTool
{
    [JsonAsset("AnimationAsset")]
    public class UAnimationAsset : UObject
    {
        public FGuid SkeletonGuid;

        [Location("void UAnimationAsset::Serialize(FArchive& Ar)")]
        public override UObject Move(Transfer transfer)
        {
            base.Move(transfer);
            if (Supports.UEVer(EUnrealEngineObjectUE4Version.VER_UE4_SKELETON_GUID_SERIALIZATION))
            {
                transfer.Move(ref SkeletonGuid);
            }
            return this;
        }
    }
}