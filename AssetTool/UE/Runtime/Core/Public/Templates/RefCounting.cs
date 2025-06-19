using AssetTool.Chaos;

namespace AssetTool
{
    public class TRefCountPtr<T> : ITransferible where T : ITransferible
    {
        public TSerializablePtr<T> Copy;

        [Location("void SerializePtr(TRefCountPtr<T>& Obj)")]
        public ITransferible Move2(Transfer transfer)
        {
            transfer.Move(ref Copy);
            return this;
        }
    }
}
