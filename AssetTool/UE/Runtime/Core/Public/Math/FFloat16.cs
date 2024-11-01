namespace AssetTool
{
    public class FFloat16
    {
        public UInt16 Encoded;

        public FFloat16 Move(Transfer transfer)
        {
            transfer.Move(ref Encoded);
            return this;
        }
    }
}
