namespace AssetTool
{
    public class PadData
    {
        public byte[] Data;
    }

    public static class StructFooterExt
    {
        public static void Write(this BinaryWriter writer, PadData item)
        {
            if (item == null || item.Data is null)
                return;
            writer.Write(item.Data);
        }

        public static void Read(this BinaryReader reader, ref PadData item)
        {
            long size = reader.BaseStream.Length - (int)reader.BaseStream.Position;
            if (size > 0)
            {
                item ??= new();
                item.Data = new byte[size];
                reader.Read(item.Data);
            }
        }

        public static void Read(this BinaryReader reader, ref PadData item, long size)
        {
            if (size > 0)
            {
                item ??= new();
                item.Data = new byte[size];
                reader.Read(item.Data);
            }
        }
    }
}
