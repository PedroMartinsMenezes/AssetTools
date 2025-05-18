namespace AssetTool
{
    [JsonAsset("AvaPlaybackEditorGraphSchema")]
    public class UAvaPlaybackEditorGraphSchema : UEdGraphSchema
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}