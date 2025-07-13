namespace AssetTool
{
    [JsonAsset("EditorFunctionLibrary")]
    public class UEditorFunctionLibrary : UBlueprintFunctionLibrary
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}