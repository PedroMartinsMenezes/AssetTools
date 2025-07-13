namespace AssetTool
{
    [JsonAsset("EditorTestsUtilityLibrary")]
    public class UEditorTestsUtilityLibrary : UBlueprintFunctionLibrary
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}