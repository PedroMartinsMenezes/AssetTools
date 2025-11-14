namespace AssetTool
{
    [JsonAsset("SkeletalMeshComponent")]
    public class USkeletalMeshComponent : USkinnedMeshComponent
    {
        [Location("void USkeletalMeshComponent::Serialize(FArchive& Ar)")]
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}