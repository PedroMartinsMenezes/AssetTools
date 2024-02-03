namespace AssetTool
{
    public class PadData
    {
        public byte[] Data;
    }

    public static class PadDataExt
    {
        public static void Write(this BinaryWriter writer, PadData item)
        {
            if (item == null) return;
            writer.Write(item.Data);
        }

        public static void Read(this BinaryReader reader, PadData item, long offset1, long offset2)
        {
            item.Data = new byte[(int)offset2 - (int)offset1];
            reader.Read(item.Data);
        }
    }
}
