namespace AssetTool
{
    [Location("void FEnumProperty::Serialize( FArchive& Ar )")]
    public class FEnumProperty : FProperty
    {
        public override string TypeName => "EnumProperty";

        public UInt32 Value;
    }

    public static class FEnumPropertyExt
    {
        public static void Write(this BinaryWriter writer, FEnumProperty item)
        {
            writer.Write(item.Value);
        }

        public static FEnumProperty Read(this BinaryReader reader, FEnumProperty item)
        {
            reader.Read(ref item.Value);
            return item;
        }
    }
}
