namespace AssetTool
{
    public class FImplementedInterface : ITransferable
    {
        public UInt32 Class;
        public Int32 PointerOffset;
        public bool bImplementedByK2;

        public ITransferable Move(Transfer transfer)
        {
            transfer.Move(ref Class);
            transfer.Move(ref PointerOffset);
            transfer.Move(ref bImplementedByK2);
            return this;
        }
    }
}
