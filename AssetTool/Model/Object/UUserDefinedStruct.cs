namespace AssetTool
{
    [Location("void UUserDefinedStructEditorData::Serialize(FArchive& Ar)")]
    public class UUserDefinedStruct : UScriptStruct
    {
        public const string TypeName = "UserDefinedStruct";

        public List<object> UserTags = new();

        public override UObject Move(Transfer transfer)
        {
            base.Move(transfer);
            transfer.MoveTags(UserTags);
            return this;
        }
    }
}
