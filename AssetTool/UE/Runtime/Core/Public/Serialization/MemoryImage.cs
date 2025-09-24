namespace AssetTool
{
    public class FPointerTableBase : ITransferible
    {
        public virtual ITransferible Move(Transfer transfer)
        {
            throw new NotImplementedException();
        }
    }

    public class FHashedName : ITransferible
    {
        public uint64 Hash;

        [Location("friend inline FArchive& operator<<(FArchive& Ar, FHashedName& String)")]
        public virtual ITransferible Move(Transfer transfer)
        {
            transfer.Move(ref Hash);
            return this;
        }
    }
}
