namespace AssetTool
{
    [JsonAsset("AutomationEditorTask")]
    public class UAutomationEditorTask : UObject
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("AutomationBlueprintFunctionLibrary")]
    public class UAutomationBlueprintFunctionLibrary : UBlueprintFunctionLibrary
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}