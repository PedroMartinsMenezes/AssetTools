namespace AssetTool
{
    public class UThumbnailInfo : UObject
    {
    }

    public static class UThumbnailInfoExt
    {
        public static void Write(this BinaryWriter writer, UThumbnailInfo item)
        {
            writer.Write((UObject)item);
        }

        public static UThumbnailInfo Read(this BinaryReader reader, UThumbnailInfo item)
        {
            reader.Read((UObject)item);
            return item;
        }
    }
}
