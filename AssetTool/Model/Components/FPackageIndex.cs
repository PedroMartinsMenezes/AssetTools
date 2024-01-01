namespace AssetTool
{
    public class FPackageIndex
    {
        public Int32 Index;
    }

    public static class FPackageIndexExt
    {
        public static void Write(this BinaryWriter writer, FPackageIndex item)
        {
            writer.Write(item.Index);
        }

        public static FPackageIndex ReadPackageIndex(this BinaryReader reader, FPackageIndex item)
        {
            reader.Read(ref item.Index);
            return item;
        }

        public static List<FPackageIndex> ReadList(this BinaryReader reader, int count, FPackageIndex item)
        {
            return Enumerable.Range(0, count).Select(x => reader.ReadPackageIndex(new FPackageIndex())).ToList();
        }
    }
}
