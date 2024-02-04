namespace AssetTool
{
    [Location("void FEnumProperty::Serialize( FArchive& Ar )")]
    public class FEnumProperty : FProperty
    {
        public UInt32 Enum;
    }

    public static class FEnumPropertyExt
    {
        public static void Write(this BinaryWriter writer, FEnumProperty item)
        {
            writer.Write(item.Enum);
        }

        public static FEnumProperty Read(this BinaryReader reader, FEnumProperty item)
        {
            reader.Read(ref item.Enum);
            return item;
        }
    }
}
