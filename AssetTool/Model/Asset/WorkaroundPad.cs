namespace AssetTool
{
    [Obsolete("Never use this class")]
    public class WorkaroundPad
    {
        public byte[] Data;

        public WorkaroundPad() { }

        public WorkaroundPad(int size)
        {
            Data = new byte[size];
        }

        public void Move(Transfer transfer)
        {
            transfer.Move(ref Data, Data.Length);
        }

        public void Move(Transfer transfer, long startOffset, long endOffset)
        {
            long before = transfer.Position;
            int size = (int)(endOffset - startOffset);
            transfer.Move(ref Data, size);
            transfer.Position = before;
        }
    }
}
