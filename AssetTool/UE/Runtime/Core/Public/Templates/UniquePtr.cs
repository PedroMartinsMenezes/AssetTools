using AssetTool.Chaos;

namespace AssetTool
{
    public class UniquePtr<T> : ITransferible where T : ITransferible, new()
    {
        public TSerializablePtr<T> Copy;

        [Location("void SerializePtr(TUniquePtr<T>& Obj)")]
        public ITransferible Move(Transfer transfer)
        {
            if (!transfer.Supports.ChaosArchiveAdded)
            {
                SerializeLegacy(transfer);
            }
            else
            {
                transfer.Move(ref Copy);

            }
            return this;
        }

        private void SerializeLegacy(Transfer transfer)
        {
            throw new NotImplementedException();
        }
    }
}
