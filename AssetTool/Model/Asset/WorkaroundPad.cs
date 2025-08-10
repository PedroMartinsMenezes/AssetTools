namespace AssetTool
{
    [Obsolete("Never use this class")]
    public class WorkaroundPad
    {
        public byte[] Data;

        public void Move(Transfer transfer)
        {
            transfer.Move(ref Data, Data.Length);
        }

        public void Move(Transfer transfer, long size)
        {
            transfer.Move(ref Data, (int)size);
        }
    }
}
