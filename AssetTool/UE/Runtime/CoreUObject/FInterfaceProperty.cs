namespace AssetTool
{
    [Location("void FInterfaceProperty::Serialize( FArchive& Ar )")]
    public class FInterfaceProperty : FProperty
    {
        public const string TYPE_NAME = "InterfaceProperty";
        public override string TypeName => TYPE_NAME;

        public UInt32 Value;
    }

    public static class FInterfacePropertyExt
    {
        public static void Write(this BinaryWriter writer, FInterfaceProperty item)
        {
            writer.Write((FProperty)item);
            writer.Write(item.Value);
        }

        public static FInterfaceProperty Read(this BinaryReader reader, FInterfaceProperty item)
        {
            reader.Read((FProperty)item);
            reader.Read(ref item.Value);
            return item;
        }
    }
}
