namespace AssetTool
{
    [JsonAsset("UserDefinedStruct")]
    public class UUserDefinedStruct : UScriptStruct
    {
        public Dictionary<string, object> UserTags = new();

        [Location("void UUserDefinedStruct::Serialize(FStructuredArchive::FRecord Record)")]
        public override ITransferible Move(Transfer transfer)
        {
            base.Move(transfer);
            transfer.MoveTags(UserTags, 0, this);
            return this;
        }
    }
}