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
    }
}
