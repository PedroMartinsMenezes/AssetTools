namespace AssetTool
{
    public class FPointerTableBase : ITransferable
    {
        public virtual ITransferable Move(Transfer transfer)
        {
            throw new NotImplementedException();
        }
    }

    public class FHashedName : ITransferable
    {
        public uint64 Hash;

        [Location("friend inline FArchive& operator<<(FArchive& Ar, FHashedName& String)")]
        public virtual ITransferable Move(Transfer transfer)
        {
            transfer.Move(ref Hash);
            return this;
        }
    }
}
