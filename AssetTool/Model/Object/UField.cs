namespace AssetTool
{
    [Location("void UField::Serialize( FArchive& Ar )")]
    public class UField : UObject
    {
        public UInt32 Next;
    }

    public static class UFieldExt
    {
        public static UField Read(this BinaryReader reader, UField item)
        {
            reader.Read((UObject)item);
            if (!Supports.CustomVer(FFrameworkObjectVersion.Enums.RemoveUField_Next))
            {
                reader.Read(ref item.Next);
            }
            return item;
        }

        public static void Write(this BinaryWriter writer, UField item)
        {
            writer.Write((UObject)item);
            if (!Supports.CustomVer(FFrameworkObjectVersion.Enums.RemoveUField_Next))
            {
                writer.Write(item.Next);
            }
        }
    }
}
