namespace AssetTool
{
    [JsonAsset("ScriptableTool_RenderAPI")]
    public class UScriptableTool_RenderAPI : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("ScriptableTool_HUDAPI")]
    public class UScriptableTool_HUDAPI : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("ScriptableInteractiveToolPropertySet")]
    public class UScriptableInteractiveToolPropertySet : UInteractiveToolPropertySet
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("ScriptableInteractiveTool")]
    public class UScriptableInteractiveTool : UInteractiveTool
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("ScriptableToolsUtilityLibrary")]
    public class UScriptableToolsUtilityLibrary : UBlueprintFunctionLibrary
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}