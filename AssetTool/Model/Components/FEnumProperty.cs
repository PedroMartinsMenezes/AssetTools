namespace AssetTool
{
    [Location("void FEnumProperty::Serialize( FArchive& Ar )")]
    public class FEnumProperty : FProperty
    {
        public const string TYPE_NAME = "EnumProperty";
        public override string TypeName => TYPE_NAME;

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
