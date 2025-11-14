namespace AssetTool
{
    [JsonAsset("AutomationEditorTask")]
    public class UAutomationEditorTask : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("AutomationBlueprintFunctionLibrary")]
    public class UAutomationBlueprintFunctionLibrary : UBlueprintFunctionLibrary
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}