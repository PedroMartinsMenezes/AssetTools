namespace AssetTool
{
    [Location("void FObjectPropertyBase::Serialize( FArchive& Ar )")]
    public class FObjectPropertyBase : FProperty
    {
        public const string TYPE_NAME = "ObjectProperty";
        public override string TypeName => TYPE_NAME;

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
