namespace AssetTool
{
    public class PadData
    {
        public byte[] Data;

        public PadData() { }

        public PadData(int size)
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
