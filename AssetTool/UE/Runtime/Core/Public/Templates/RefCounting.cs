namespace AssetTool
{
    public class TRefCountPtr<T> : ITransferible where T : ITransferible, new()
    {
        public TSerializablePtr<T> Copy;

        [Location("void SerializePtr(TRefCountPtr<T>& Obj)")]
        public ITransferible Move(Transfer transfer)
        {
            transfer.Move(ref Copy);
            return this;
        }
    }
}
