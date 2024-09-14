namespace AssetTool
{
    public class FImplementedInterface
    {
        public UInt32 Class;
        public Int32 PointerOffset;
        public FBool bImplementedByK2;

        public FImplementedInterface Move(Transfer transfer)
        {
            transfer.Move(ref Class);
            transfer.Move(ref PointerOffset);
            transfer.Move(ref bImplementedByK2);
            return this;
        }
    }
}
