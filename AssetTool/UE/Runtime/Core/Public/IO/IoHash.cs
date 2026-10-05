namespace AssetTool
{
    public class FIoHash : ITransferable
    {
        public byte[] ByteArray = new byte[20];

        public ITransferable Move(Transfer transfer)
        {
            transfer.Move(ref ByteArray, 20);
            return this;
        }
    }
}
