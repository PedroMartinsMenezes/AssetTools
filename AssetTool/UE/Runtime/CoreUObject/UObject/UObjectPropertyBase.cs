namespace AssetTool
{
    [Location("void UObjectPropertyBase::Serialize(FArchive& Ar)")]
    public class UObjectPropertyBase : UProperty
    {
        public UInt32 PropertyClass;
    }

    public static class UObjectPropertyBaseExt
    {
        public static UObjectPropertyBase Read(this BinaryReader reader, UObjectPropertyBase item)
        {
            reader.Read((UProperty)item);

            reader.Read(ref item.PropertyClass);

            return item;
        }

        public static void Write(this BinaryWriter writer, UObjectPropertyBase item)
        {
            writer.Write((UProperty)item);

            writer.Write(item.PropertyClass);
        }
    }
}
