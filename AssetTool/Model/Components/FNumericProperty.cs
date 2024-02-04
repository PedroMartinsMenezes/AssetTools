namespace AssetTool
{
    [Location("void FNumericProperty::Serialize(FArchive& Ar)")]
    public class FNumericProperty : FProperty
    {
        public UInt64 Value;
    }

    public static class FNumericPropertyExt
    {
        public static void Write(this BinaryWriter writer, FNumericProperty item)
        {
            writer.Write(item.Value);
        }

        public static void Read(this BinaryReader reader, FNumericProperty item)
        {
            reader.Read(ref item.Value);
        }
    }
}
