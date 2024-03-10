namespace AssetTool
{
    [Location("void UObjectPropertyBase::Serialize(FArchive& Ar)")]
    public class UObjectProperty : UObjectPropertyBase
    {
        public const string TypeName = "ObjectProperty";
    }

    public static class UObjectPropertyExt
    {
        public static UObjectProperty Read(this BinaryReader reader, UObjectProperty item)
        {
            reader.Read((UObjectPropertyBase)item);
            return item;
        }

        public static void Write(this BinaryWriter writer, UObjectProperty item)
        {
            writer.Write((UObjectPropertyBase)item);
        }
    }
}
