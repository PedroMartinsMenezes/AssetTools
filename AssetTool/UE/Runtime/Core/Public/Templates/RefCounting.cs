using AssetTool.Chaos;

namespace AssetTool
{
    public class TRefCountPtr<T> : ITransferable where T : ITransferable
    {
        public TSerializablePtr<T> Copy;

        [Location("void SerializePtr(TRefCountPtr<T>& Obj)")]
        public ITransferable Move(Transfer transfer)
        {
            transfer.Move(ref Copy);
            return this;
        }
    }
}
