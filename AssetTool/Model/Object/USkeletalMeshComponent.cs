namespace AssetTool
{
    [Location("void USkeletalMeshComponent::Serialize(FArchive& Ar)")]
    [JsonAsset("SkeletalMeshComponent")]
    public class USkeletalMeshComponent : USkinnedMeshComponent
    {
        public new const string TypeName = "SkeletalMeshComponent";
    }
}
