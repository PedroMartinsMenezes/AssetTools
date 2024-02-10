namespace AssetTool
{
    [Location("void FStructProperty::Serialize( FArchive& Ar )")]
    public class FStructProperty : FProperty
    {
        public override string TypeName => "StructProperty";

        public UInt32 Value;
    }

    public static class FStructPropertyExt
    {
        public static void Write(this BinaryWriter writer, FStructProperty item)
        {
            writer.Write((FProperty)item);
            writer.Write(item.Value);
        }

        public static FStructProperty Read(this BinaryReader reader, FStructProperty item)
        {
            reader.Read((FProperty)item);
            reader.Read(ref item.Value);
            return item;
        }
    }
}
