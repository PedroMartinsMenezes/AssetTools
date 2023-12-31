namespace AssetTool
{
    public class FNameEntryId
    {
        public UInt32 Value;
    }

    public static class FNameEntryIdExt
    {
        public static void Write(this BinaryWriter writer, FNameEntryId name)
        {
            writer.Write(name.Value);
        }

        public static void Read(this BinaryReader reader, FNameEntryId item)
        {
            reader.Read(ref item.Value);
        }
    }
}
