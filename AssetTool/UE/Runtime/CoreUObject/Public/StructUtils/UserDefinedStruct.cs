namespace AssetTool
{
    [JsonAsset("UserDefinedStruct")]
    public class UUserDefinedStruct : UScriptStruct
    {
        public UScriptStruct UScriptStruct;

        [Location("void UUserDefinedStruct::Serialize(FStructuredArchive::FRecord Record)")]
        public override ITransferible Move(Transfer transfer)
        {
            base.Move(transfer);
            if (transfer.GlobalObjects.CurrentObject.ObjectFlags.HasFlag(EObjectFlags.RF_ClassDefaultObject))
            {
                return this;
            }
            if (transfer.Supports.UserDefinedStructsStoreDefaultInstance)
            {
                UScriptStruct ??= new UScriptStruct();
                UScriptStruct.SerializeItem(transfer);
            }
            return this;
        }
    }
}