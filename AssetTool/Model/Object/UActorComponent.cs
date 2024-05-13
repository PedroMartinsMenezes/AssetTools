namespace AssetTool
{
    [Location("void UActorComponent::Serialize(FArchive& Ar)")]
    public class UActorComponent : UObject
    {
        [Sized] public List<FSimpleMemberReference> UCSModifiedProperties = new();

        public new UActorComponent Move(Transfer transfer)
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
