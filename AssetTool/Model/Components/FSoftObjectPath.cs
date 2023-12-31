namespace AssetTool
{
    //SoftPackageReferencesOffset 2060..2080
    public class FSoftObjectPath
    {
        public FTopLevelAssetPath AssetPath = new();
        public FString SubPathString = new();
    }

    public static class SoftObjectPathExt
    {
        public static void Write(this BinaryWriter writer, FSoftObjectPath item)
        {
            if (item is null) return;
            writer.Write(item.AssetPath);
            writer.Write(item.SubPathString);
        }

        public static List<FSoftObjectPath> ReadList(this BinaryReader reader, int count, FSoftObjectPath item)
        {
            return Enumerable.Range(0, count).Select(x => reader.Read(new FSoftObjectPath())).ToList();
        }

        public static FSoftObjectPath Read(this BinaryReader reader, FSoftObjectPath item)
        {
            reader.Read(item.AssetPath);
            reader.Read(ref item.SubPathString);
            return item;
        }
    }
}
