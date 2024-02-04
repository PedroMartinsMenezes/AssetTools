namespace AssetTool
{
    public class UFunction : UStruct
    {
    }

    public static class UFunctionExt
    {
        public static void Write(this BinaryWriter writer, UFunction item)
        {
            writer.Write((UStruct)item);
        }

        public static UFunction Read(this BinaryReader reader, UFunction item)
        {
            reader.Read((UStruct)item);
            return item;
        }
    }
}
