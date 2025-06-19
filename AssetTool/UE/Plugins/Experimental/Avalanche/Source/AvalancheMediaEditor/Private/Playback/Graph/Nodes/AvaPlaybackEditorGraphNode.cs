namespace AssetTool
{
    [JsonAsset("AvaPlaybackEditorGraphNode")]
    public class UAvaPlaybackEditorGraphNode : UEdGraphNode
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}