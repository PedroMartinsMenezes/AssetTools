namespace AssetTool
{
    public class UArrowComponent : UPrimitiveComponent
    {
        public const string TypeName = "ArrowComponent";
    }

    public static class UArrowComponentExt
    {
        public static void Write(this BinaryWriter writer, UArrowComponent item)
        {
            writer.Write((UPrimitiveComponent)item);
        }

        public static UArrowComponent Read(this BinaryReader reader, UArrowComponent item)
        {
            reader.Read((UPrimitiveComponent)item);
            return item;
        }
    }
}
