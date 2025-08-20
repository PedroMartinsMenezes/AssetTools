namespace AssetTool
{
    public class TTransArray<T> : ITransferible where T : ITransferible, new()
    {
        public UInt32 Owner;
        public List<T> Items;

        [Location("friend FArchive& operator<<( FArchive& Ar, TTransArray& A )")]
        public ITransferible Move(Transfer transfer)
        {
            transfer.Move(ref Owner);
            transfer.Move(ref Items);
            return this;
        }
    }
}
