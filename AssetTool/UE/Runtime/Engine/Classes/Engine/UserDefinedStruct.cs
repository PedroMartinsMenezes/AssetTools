namespace AssetTool
{
    [JsonAsset("UserDefinedStruct")]
    public class UUserDefinedStruct : UScriptStruct
    {
        public List<object> UserTags = new();

        [Location("void UUserDefinedStruct::Serialize(FStructuredArchive::FRecord Record)")]
        public override UObject Move(Transfer transfer)
        {
            base.Move(transfer);
            transfer.MoveTags(UserTags, 0, this);
            return this;
        }
    }
}