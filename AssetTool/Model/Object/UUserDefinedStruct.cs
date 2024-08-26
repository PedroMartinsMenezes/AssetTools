namespace AssetTool
{
    [Location("void UUserDefinedStructEditorData::Serialize(FArchive& Ar)")]
    [JsonAsset]
    public class UUserDefinedStruct : UScriptStruct
    {
        public new const string TypeName = "UserDefinedStruct";

        public List<object> UserTags = new();

        public override UObject Move(Transfer transfer)
        {
            base.Move(transfer);
            transfer.MoveTags(UserTags, 0, this);
            return this;
        }
    }
}
