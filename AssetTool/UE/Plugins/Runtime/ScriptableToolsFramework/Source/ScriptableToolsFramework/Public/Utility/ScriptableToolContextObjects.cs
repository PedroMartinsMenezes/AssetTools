namespace AssetTool
{
    [JsonAsset("ScriptableToolContextObject")]
    public class UScriptableToolContextObject : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("ScriptableToolViewportWidgetAPI")]
    public class UScriptableToolViewportWidgetAPI : UScriptableToolContextObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}