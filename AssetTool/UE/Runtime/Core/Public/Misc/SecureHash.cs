namespace AssetTool
{
    public class FSHAHash : ITransferable
    {
        public TUInt8[] Hash;

        public ITransferable Move(Transfer transfer)
        {
            transfer.Move(ref Hash, 20);
            return this;
        }
    }
}
