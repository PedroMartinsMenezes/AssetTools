namespace AssetTool
{
    public class FMD5Hash : ITransferable
    {
        public bool bIsValid;
        public byte[] Bytes = new byte[16];

        public ITransferable Move(Transfer transfer)
        {
            transfer.Move(ref bIsValid);
            if (bIsValid)
            {
                transfer.Move(ref Bytes, 16);
            }
            return this;
        }
    }
}
