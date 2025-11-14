namespace AssetTool
{
    public class TTransArray<T> : ITransferable where T : ITransferable, new()
    {
        public UInt32 Owner;
        public List<T> Items;

        [Location("friend FArchive& operator<<( FArchive& Ar, TTransArray& A )")]
        public ITransferable Move(Transfer transfer)
        {
            transfer.Move(ref Owner);
            transfer.Move(ref Items);
            return this;
        }
    }
}
