namespace AssetTool
{
    [Location("void FInterfaceProperty::Serialize( FArchive& Ar )")]
    public class FInterfaceProperty : FProperty
    {
        public UInt32 InterfaceClass;
    }

    public static class FInterfacePropertyExt
    {
        public static void Write(this BinaryWriter writer, FInterfaceProperty item)
        {
            writer.Write((FProperty)item);
            writer.Write(item.InterfaceClass);
        }

        public static FInterfaceProperty Read(this BinaryReader reader, FInterfaceProperty item)
        {
            reader.Read((FProperty)item);
            reader.Read(ref item.InterfaceClass);
            return item;
        }
    }
}
