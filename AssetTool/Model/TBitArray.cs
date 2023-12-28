namespace AssetTool.Model
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
            writer.Write(item.NumBits);
            if (item.NumBits > 0)
                writer.Write(item.MaxBits);
        }
    }
}
