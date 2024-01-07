namespace AssetTool.Model
{
    //2879..3730
    public class UUserDefinedStruct : UScriptStruct
    {
        public new List<FPropertyTag> Tags = new();
    }

    public static class UUserDefinedStructExt
    {
        public static void Write(this BinaryWriter writer, UUserDefinedStruct item)
        {
            writer.Write((UScriptStruct)item);
            writer.Write(item.Tags);
        }

        public static UUserDefinedStruct Read(this BinaryReader reader, UUserDefinedStruct item)
        {
            reader.Read((UScriptStruct)item);
            reader.Read(item.Tags);
            return item;
        }
    }
}
