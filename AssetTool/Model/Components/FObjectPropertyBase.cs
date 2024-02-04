namespace AssetTool
{
    [Location("void FObjectPropertyBase::Serialize( FArchive& Ar )")]
    public class FObjectPropertyBase : FProperty
    {
        public UInt32 PropertyClass;
    }

    public static class FObjectPropertyBaseExt
    {
        public static void Write(this BinaryWriter writer, FObjectPropertyBase item)
        {
            writer.Write((FProperty)item);
            writer.Write(item.PropertyClass);
        }

        public static FObjectPropertyBase Read(this BinaryReader reader, FObjectPropertyBase item)
        {
            reader.Read((FProperty)item);
            reader.Read(ref item.PropertyClass);
            return item;
        }
    }
}
