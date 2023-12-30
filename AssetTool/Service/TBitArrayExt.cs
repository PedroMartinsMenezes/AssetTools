using AssetTool.Model;

namespace AssetTool.Service
{
    public static class TBitArrayExt
    {
        public static void Write(this BinaryWriter writer, TBitArray item)
        {
            writer.Write(item.NumBits);
            if (item.NumBits > 0)
                writer.Write(item.MaxBits);
        }

        public static TBitArray Read(this BinaryReader reader, TBitArray item)
        {
            reader.Read(ref item.NumBits);
            reader.Read(ref item.MaxBits);
            return item;
        }
    }
}
