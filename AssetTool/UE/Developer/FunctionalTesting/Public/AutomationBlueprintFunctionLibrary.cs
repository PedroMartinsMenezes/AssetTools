namespace AssetTool
{
    [JsonAsset("AutomationEditorTask")]
    public class UAutomationEditorTask : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("AutomationBlueprintFunctionLibrary")]
    public class UAutomationBlueprintFunctionLibrary : UBlueprintFunctionLibrary
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}