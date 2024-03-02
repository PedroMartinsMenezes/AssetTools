namespace AssetTool
{
    [Location("void UObject::Serialize(FStructuredArchive::FRecord Record)")]
    public class USceneThumbnailInfoWithPrimitive : UObject
    {
        public const string TypeName = "SceneThumbnailInfoWithPrimitive";
    }

    public static class USceneThumbnailInfoWithPrimitiveExt
    {
        public static void Write(this BinaryWriter writer, USceneThumbnailInfoWithPrimitive item)
        {
            writer.Write((UObject)item);
        }

        public static USceneThumbnailInfoWithPrimitive Read(this BinaryReader reader, USceneThumbnailInfoWithPrimitive item)
        {
            reader.Read((UObject)item);

            return item;
        }
    }
}
