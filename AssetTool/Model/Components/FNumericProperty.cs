namespace AssetTool
{
    [Location("void FNumericProperty::Serialize(FArchive& Ar)")]
    public class FNumericProperty : FProperty
    {
    }

    public static class FNumericPropertyExt
    {
        public static void Write(this BinaryWriter writer, FNumericProperty item)
        {
            writer.Write((FProperty)item);
        }

        public static FNumericProperty Read(this BinaryReader reader, FNumericProperty item)
        {
            reader.Read((FProperty)item);
            return item;
        }
    }
}
