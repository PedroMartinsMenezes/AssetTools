namespace AssetTool
{
    [Location("void UUserDefinedStructEditorData::Serialize(FArchive& Ar)")]
    public class UUserDefinedStruct : UScriptStruct
    {
        public const string TypeName = "UserDefinedStruct";

        public List<FPropertyTag> UserTags = new();
    }

    public static class UUserDefinedStructExt
    {
        public static void Write(this BinaryWriter writer, UUserDefinedStruct item)
        {
            writer.Write((UScriptStruct)item);
            writer.WriteTags(item.UserTags);
        }

        public static void Read(this BinaryReader reader, UUserDefinedStruct item)
        {
            reader.Read((UScriptStruct)item);
            reader.ReadTags(item.UserTags);
        }
    }
}
