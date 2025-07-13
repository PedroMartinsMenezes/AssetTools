namespace AssetTool
{
    [JsonAsset("EditorUtilityBlueprintAsyncActionBase")]
    public class UEditorUtilityBlueprintAsyncActionBase : UBlueprintAsyncActionBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("AsyncEditorDelay")]
    public class UAsyncEditorDelay : UEditorUtilityBlueprintAsyncActionBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("AsyncEditorWaitForGameWorld")]
    public class UAsyncEditorWaitForGameWorld : UEditorUtilityBlueprintAsyncActionBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("AsyncEditorOpenMapAndFocusActor")]
    public class UAsyncEditorOpenMapAndFocusActor : UEditorUtilityBlueprintAsyncActionBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("EditorUtilityLibrary")]
    public class UEditorUtilityLibrary : UBlueprintFunctionLibrary
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}