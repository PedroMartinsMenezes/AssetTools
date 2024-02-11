namespace AssetTool
{
    //8054..8106
    public class StructFooter
    {
        public byte[] Data;
    }

    public static class StructFooterExt
    {
        public static void Write(this BinaryWriter writer, StructFooter item)
        {
            if (item == null || item.Data is null) return;
            writer.Write(item.Data);
        }

        public static void Read(this BinaryReader reader, StructFooter item)
        {
            item.Data = new byte[(int)reader.BaseStream.Length - (int)reader.BaseStream.Position];
            reader.Read(item.Data);
        }
    }
}
