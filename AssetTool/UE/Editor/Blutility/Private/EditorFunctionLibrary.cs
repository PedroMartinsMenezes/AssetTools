namespace AssetTool
{
    [JsonAsset("EditorFunctionLibrary")]
    public class UEditorFunctionLibrary : UBlueprintFunctionLibrary
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}