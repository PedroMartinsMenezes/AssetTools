using System.ComponentModel;
using System.Text.Json.Serialization;

namespace AssetTool
{
    [Description("Represents the UEXP file generated for Cooked assets")]
    public class FooterData
    {
        public byte[] Data;

        [JsonIgnore] public int Length => Data?.Length ?? 0;

        public void Move(Transfer transfer, int size)
        {
            transfer.Move(ref Data, size);
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
