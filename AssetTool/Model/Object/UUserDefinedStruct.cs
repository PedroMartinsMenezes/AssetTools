namespace AssetTool.Model
{
    //2879..3730
    public class UUserDefinedStruct : UStruct
    {
        public FGuid Guid;
    }

    public static class UUserDefinedStructExt
    {
        public static void Write(this BinaryWriter writer, UUserDefinedStruct item)
        {
            writer.Write((UStruct)item);

            writer.Write(item.Guid);
        }

        public static UUserDefinedStruct Read(this BinaryReader reader, UUserDefinedStruct item)
        {
            reader.Read((UStruct)item);

            reader.Read(ref item.Guid);
            return item;
        }
    }
}
