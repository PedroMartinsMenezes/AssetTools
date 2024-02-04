namespace AssetTool
{
    [Location("void FMulticastDelegateProperty::Serialize( FArchive& Ar )")]
    public class FMulticastDelegateProperty : FProperty
    {
        public UInt32 SignatureFunction;
    }

    public static class FMulticastDelegatePropertyExt
    {
        public static void Write(this BinaryWriter writer, FMulticastDelegateProperty item)
        {
            writer.Write((FProperty)item);
            writer.Write(item.SignatureFunction);
        }

        public static void Read(this BinaryReader reader, FMulticastDelegateProperty item)
        {
            reader.Read((FProperty)item);
            reader.Read(ref item.SignatureFunction);
        }
    }
}
