namespace AssetTool
{
    [JsonAsset("EditorTestsUtilityLibrary")]
    public class UEditorTestsUtilityLibrary : UBlueprintFunctionLibrary
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}