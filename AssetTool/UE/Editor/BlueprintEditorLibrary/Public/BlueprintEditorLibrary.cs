namespace AssetTool
{
    [JsonAsset("BlueprintEditorLibrary")]
    public class UBlueprintEditorLibrary : UBlueprintFunctionLibrary
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}