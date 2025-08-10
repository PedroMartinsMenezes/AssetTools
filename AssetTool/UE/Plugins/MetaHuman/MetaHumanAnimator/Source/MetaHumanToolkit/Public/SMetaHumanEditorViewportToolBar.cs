namespace AssetTool
{
    [JsonAsset("MetaHumanEditorViewportViewMenuContext")]
    public class UMetaHumanEditorViewportViewMenuContext : UEditorViewportViewMenuContext
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}