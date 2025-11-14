namespace AssetTool
{
    [JsonAsset("AvaPlaybackEditorGraphNode")]
    public class UAvaPlaybackEditorGraphNode : UEdGraphNode
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}