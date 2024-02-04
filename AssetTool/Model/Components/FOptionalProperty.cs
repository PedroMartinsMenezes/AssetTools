namespace AssetTool
{
    [Location("void FOptionalProperty::Serialize(FArchive& Ar)")]
    public class FOptionalProperty : FProperty
    {
        public UInt32 ValueProperty;
    }

    public static class FOptionalPropertyExt
    {
        public static void Write(this BinaryWriter writer, FOptionalProperty item)
        {
            writer.Write(item.ValueProperty);
        }

        public static void Read(this BinaryReader reader, FOptionalProperty item)
        {
            reader.Read(ref item.ValueProperty);
        }
    }
}
