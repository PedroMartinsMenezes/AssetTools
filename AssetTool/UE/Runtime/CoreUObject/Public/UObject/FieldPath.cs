namespace AssetTool
{
    public class FFieldPath : ITransferible
    {
        public List<FName> Path;
        public UInt32 SerializedOwner;

        [Location("FArchive& operator<<(FArchive& Ar, FFieldPath& InOutPropertyPath)")]
        public ITransferible Move(Transfer transfer)
        {
            transfer.Move(ref Path);
            if (transfer.Supports.FFieldPathOwnerSerialization)
            {
                transfer.Move(ref SerializedOwner);
            }
            return this;
        }
    }
}
