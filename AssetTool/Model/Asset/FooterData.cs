using System.ComponentModel;

namespace AssetTool
{
    [Description("Represents the UEXP file generated for Cooked assets")]
    public class FooterData
    {
        public byte[] Data;

        public FooterData() { }

        public FooterData(int size)
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
