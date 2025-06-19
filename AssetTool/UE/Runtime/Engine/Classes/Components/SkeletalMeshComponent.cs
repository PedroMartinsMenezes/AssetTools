namespace AssetTool
{
    [JsonAsset("SkeletalMeshComponent")]
    public class USkeletalMeshComponent : USkinnedMeshComponent
    {
        [Location("void USkeletalMeshComponent::Serialize(FArchive& Ar)")]
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}