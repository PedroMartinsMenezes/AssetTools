namespace AssetTool
{
    [Location("void UActorComponent::Serialize(FArchive& Ar)")]
    public class UActorComponent : UObject
    {
        [Sized] public List<FSimpleMemberReference> UCSModifiedProperties = new();

        public new UActorComponent Read(BinaryReader reader)
        {
            base.Read(reader);

            if (GlobalObjects.CustomVer(FFortniteReleaseBranchCustomObjectVersion.Guid) >= (int)FFortniteReleaseBranchCustomObjectVersion.Enums.ActorComponentUCSModifiedPropertiesSparseStorage)
            {
                reader.ReadValue(UCSModifiedProperties, GetType().GetField("UCSModifiedProperties"));
            }
            return this;
        }
        public new void Write(BinaryWriter writer)
        {
            base.Write(writer);

            if (GlobalObjects.CustomVer(FFortniteReleaseBranchCustomObjectVersion.Guid) >= (int)FFortniteReleaseBranchCustomObjectVersion.Enums.ActorComponentUCSModifiedPropertiesSparseStorage)
            {
                writer.WriteValue(UCSModifiedProperties, GetType().GetField("UCSModifiedProperties"));
            }
        }
    }
}
