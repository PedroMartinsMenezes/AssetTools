namespace AssetTool
{
    [Location("FIntProperty::Serialize( FArchive& Ar )")]
    public class FIntProperty : FNumericProperty
    {
        public const string TypeName = "IntProperty";
    }

    public static class FIntPropertyExt
    {
        public static void Write(this BinaryWriter writer, FIntProperty item)
        {
            writer.Write((FNumericProperty)item);
        }

        public static FIntProperty Read(this BinaryReader reader, FIntProperty item)
        {
            reader.Read((FNumericProperty)item);
            return item;
        }
    }
}
