namespace AssetTool
{
    public class PadData
    {
        public byte[] Data;

        public void Move(Transfer transfer, int size)
        {
            if (size > 0 || Data is { })
            {
                transfer.Move(ref Data, size);
            }
        }

        public void Move(Transfer transfer)
        {
            int size = (int)transfer.Length - (int)transfer.Position;
            if (size > 0 || Data is { })
            {
                transfer.Move(ref Data, size);
            }
        }
    }
}
