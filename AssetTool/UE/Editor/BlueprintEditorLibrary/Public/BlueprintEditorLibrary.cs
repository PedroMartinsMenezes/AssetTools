namespace AssetTool
{
    [JsonAsset("BlueprintEditorLibrary")]
    public class UBlueprintEditorLibrary : UBlueprintFunctionLibrary
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}