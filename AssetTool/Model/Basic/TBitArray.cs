namespace AssetTool
{
    public class TBitArray
    {
        public Int32 NumBits;
        public Int32 MaxBits;
    }

    public static class TBitArrayExt
    {
        public static void Write(this BinaryWriter writer, TBitArray item)
        {
            if (item is null) return;
            writer.Write(item.NumBits);
            if (item.NumBits > 0)
                writer.Write(item.MaxBits);
        }

        public static TBitArray Read(this BinaryReader reader, TBitArray item)
        {
            reader.Read(ref item.NumBits);
            if (item.NumBits > 0)
                reader.Read(ref item.MaxBits);
            return item;
        }
    }
}
