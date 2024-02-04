namespace AssetTool
{
    [Location("void FStructProperty::Serialize( FArchive& Ar )")]
    public class FStructProperty : FProperty
    {
        public UInt32 Struct;
    }

    public static class FStructPropertyExt
    {
        public static void Write(this BinaryWriter writer, FStructProperty item)
        {
            writer.Write((FProperty)item);
            writer.Write(item.Struct);
        }

        public static FStructProperty Read(this BinaryReader reader, FStructProperty item)
        {
            reader.Read((FProperty)item);
            reader.Read(ref item.Struct);
            return item;
        }
    }
}
