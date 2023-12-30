namespace AssetTool.Model
{
    //73 bytes. 2608..2681
    public class Gap2
    {
        public byte[] Gap = new byte[73];
    }

    public static class Gap2Ext
    {
        public static void Write(this BinaryWriter writer, Gap2 item)
        {
            writer.Write(item.Gap);
        }

        public static Gap2 Read(this BinaryReader reader, Gap2 item)
        {
            reader.Read(item.Gap);
            return item;
        }
    }
}
