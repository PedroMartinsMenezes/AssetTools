namespace AssetTool
{
    public class USceneThumbnailInfo : UThumbnailInfo
    {
        public const string TypeName = "SceneThumbnailInfo";
    }

    public static class USceneThumbnailInfoExt
    {
        public static void Write(this BinaryWriter writer, USceneThumbnailInfo item)
        {
            writer.Write((UObject)item);
        }

        public static USceneThumbnailInfo Read(this BinaryReader reader, USceneThumbnailInfo item)
        {
            reader.Read((UObject)item);
            return item;
        }
    }
}
