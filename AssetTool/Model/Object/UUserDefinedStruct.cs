namespace AssetTool
{
    [Location("void UUserDefinedStructEditorData::Serialize(FArchive& Ar)")]
    public class UUserDefinedStruct : UScriptStruct
    {
        public const string TypeName = "UserDefinedStruct";

        public List<object> UserTags = new();

        public new UUserDefinedStruct Read(BinaryReader reader)
        {
            base.Read(reader);
            reader.ReadTags(UserTags);
            return this;
        }
        public new void Write(BinaryWriter writer)
        {
            base.Write(writer);
            writer.WriteTags(UserTags);
        }
    }
}
