namespace AssetTool
{
    [JsonAsset("EditorFilterLibrary")]
    public class UEditorFilterLibrary : UBlueprintFunctionLibrary
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}