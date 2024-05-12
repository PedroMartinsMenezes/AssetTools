namespace AssetTool
{
    [Location("void UActorComponent::Serialize(FArchive& Ar)")]
    public class UActorComponent : UObject
    {
        [Sized] public List<FSimpleMemberReference> UCSModifiedProperties = new();

        public new UActorComponent Move(Transfer transfer)
        {
            if (transfer.IsReading)
                return Read(transfer.reader);
            else
                return Write(transfer.writer);
        }

        public UActorComponent Read(BinaryReader reader)
        {
            base.Move(GlobalObjects.Transfer);

            if (GlobalObjects.CustomVer(FFortniteReleaseBranchCustomObjectVersion.Guid) >= (int)FFortniteReleaseBranchCustomObjectVersion.Enums.ActorComponentUCSModifiedPropertiesSparseStorage)
            {
                reader.ReadValue(UCSModifiedProperties, GetType().GetField("UCSModifiedProperties"));
            }
            return this;
        }
        public UActorComponent Write(BinaryWriter writer)
        {
            base.Move(GlobalObjects.Transfer);

            if (GlobalObjects.CustomVer(FFortniteReleaseBranchCustomObjectVersion.Guid) >= (int)FFortniteReleaseBranchCustomObjectVersion.Enums.ActorComponentUCSModifiedPropertiesSparseStorage)
            {
                writer.WriteValue(UCSModifiedProperties, GetType().GetField("UCSModifiedProperties"));
            }
            return this;
        }
    }
}
