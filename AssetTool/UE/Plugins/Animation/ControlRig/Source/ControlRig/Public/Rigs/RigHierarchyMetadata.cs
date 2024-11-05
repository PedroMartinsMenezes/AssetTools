namespace AssetTool
{
    public class FRigBaseMetadata : ITransferible
    {
        public FName Name;
        public ERigMetadataType Type;

        [Location("void FRigBaseMetadata::Serialize(FArchive& Ar, bool bIsLoading)")]
        public ITransferible Move(Transfer transfer)
        {
            transfer.Move(ref Name);
            Type = (ERigMetadataType)transfer.Move((byte)Type);
            return this;
        }
    }
}
