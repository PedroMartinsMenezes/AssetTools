namespace AssetTool
{
    [Location("void UActorComponent::Serialize(FArchive& Ar)")]
    public class UActorComponent : UObject
    {
        [Sized] public List<FSimpleMemberReference> UCSModifiedProperties = new();

        public new UActorComponent Move(Transfer transfer)
        {
            base.Move(transfer);
            if (transfer.IsReading)
                return Read(transfer.reader);
            else
                return Write(transfer.writer);
        }

        private UActorComponent Read(BinaryReader reader)
        {
            if (GlobalObjects.CustomVer(FFortniteReleaseBranchCustomObjectVersion.Guid) >= (int)FFortniteReleaseBranchCustomObjectVersion.Enums.ActorComponentUCSModifiedPropertiesSparseStorage)
            {
                reader.ReadValue(UCSModifiedProperties, GetType().GetField("UCSModifiedProperties"));
            }
            return this;
        }
        private UActorComponent Write(BinaryWriter writer)
        {
            if (GlobalObjects.CustomVer(FFortniteReleaseBranchCustomObjectVersion.Guid) >= (int)FFortniteReleaseBranchCustomObjectVersion.Enums.ActorComponentUCSModifiedPropertiesSparseStorage)
            {
                writer.WriteValue(UCSModifiedProperties, GetType().GetField("UCSModifiedProperties"));
            }
            return this;
        }
    }
}
