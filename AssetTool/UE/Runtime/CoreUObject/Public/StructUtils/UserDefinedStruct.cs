namespace AssetTool
{
    [JsonAsset("UserDefinedStruct")]
    public class UUserDefinedStruct : UScriptStruct
    {
        public Dictionary<string, object> UserTags = new();

        [Location("void UUserDefinedStruct::Serialize(FStructuredArchive::FRecord Record)")]
        public override ITransferable Move(Transfer transfer)
        {
            base.Move(transfer);
            if (transfer.GlobalObjects.CurrentObject.ObjectFlags.HasFlag(EObjectFlags.RF_ClassDefaultObject))
            {
                return this;
            }
            if (transfer.Supports.UserDefinedStructsStoreDefaultInstance)
            {
                transfer.MoveTags(UserTags, 0, this);
            }
            return this;
        }
    }
}