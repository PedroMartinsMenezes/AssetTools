namespace AssetTool
{
    [Location("void FObjectPropertyBase::Serialize( FArchive& Ar )")]
    public class FObjectPropertyBase : FProperty
    {
        public override string TypeName => "ObjectProperty";

        public UInt32 Value;
    }

    public static class FObjectPropertyBaseExt
    {
        public static void Write(this BinaryWriter writer, FObjectPropertyBase item)
        {
            writer.Write((FProperty)item);
            writer.Write(item.Value);
        }

        public static FObjectPropertyBase Read(this BinaryReader reader, FObjectPropertyBase item)
        {
            reader.Read((FProperty)item);
            reader.Read(ref item.Value);
            return item;
        }
    }
}
