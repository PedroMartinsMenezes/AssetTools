namespace AssetTool
{
    [JsonAsset("ActorComponent")]
    public class UActorComponent : UObject
    {
        public List<FSimpleMemberReference> UCSModifiedProperties = new();

        [Location("void UActorComponent::Serialize(FArchive& Ar)")]
        public override UObject Move(Transfer transfer)
        {
            base.Move(transfer);
            if (GlobalObjects.CustomVer(FFortniteReleaseBranchCustomObjectVersion.Guid) >= (int)FFortniteReleaseBranchCustomObjectVersion.Enums.ActorComponentUCSModifiedPropertiesSparseStorage)
            {
                UCSModifiedProperties.Resize(transfer).ForEach(x => x.Move(transfer));
            }
            return this;
        }
    }
}
