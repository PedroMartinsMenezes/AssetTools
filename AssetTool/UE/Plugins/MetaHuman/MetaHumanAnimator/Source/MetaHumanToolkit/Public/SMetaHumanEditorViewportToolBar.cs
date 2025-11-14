namespace AssetTool
{
    [JsonAsset("MetaHumanEditorViewportViewMenuContext")]
    public class UMetaHumanEditorViewportViewMenuContext : UEditorViewportViewMenuContext
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}