namespace AssetTool
{
    public class FSHAHash : ITransferible
    {
        public TUInt8[] Hash;

        public ITransferible Move(Transfer transfer)
        {
            transfer.Move(ref Hash, 20);
            return this;
        }
    }
}
