namespace AssetTool
{
    [JsonAsset("AvaPlaybackEditorGraphSchema")]
    public class UAvaPlaybackEditorGraphSchema : UEdGraphSchema
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}