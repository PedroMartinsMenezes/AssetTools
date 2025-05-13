namespace AssetTool
{
    public class FMD5Hash : ITransferible
    {
        public FBool bIsValid;
        public byte[] Bytes = new byte[16];

        public ITransferible Move(Transfer transfer)
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
