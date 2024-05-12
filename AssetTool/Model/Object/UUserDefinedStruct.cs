namespace AssetTool
{
    [Location("void UUserDefinedStructEditorData::Serialize(FArchive& Ar)")]
    public class UUserDefinedStruct : UScriptStruct
    {
        public const string TypeName = "UserDefinedStruct";

        public List<object> UserTags = new();

        public new UUserDefinedStruct Move(Transfer transfer)
        {
            base.Move(transfer);
            if (transfer.IsReading)
                transfer.reader.ReadTags(UserTags);
            else
                transfer.writer.WriteTags(UserTags);
            return this;
        }
    }
}
