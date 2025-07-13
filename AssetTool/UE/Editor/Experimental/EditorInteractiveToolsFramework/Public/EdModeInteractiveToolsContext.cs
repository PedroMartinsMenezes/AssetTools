namespace AssetTool
{
    [JsonAsset("EditorInteractiveToolsContext")]
    public class UEditorInteractiveToolsContext : UInteractiveToolsContext
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("ModeManagerInteractiveToolsContext")]
    public class UModeManagerInteractiveToolsContext : UEditorInteractiveToolsContext
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("EdModeInteractiveToolsContext")]
    public class UEdModeInteractiveToolsContext : UEditorInteractiveToolsContext
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}