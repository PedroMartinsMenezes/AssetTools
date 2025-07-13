namespace AssetTool
{
    [JsonAsset("PluginReferenceViewerSchema")]
    public class UPluginReferenceViewerSchema : UEdGraphSchema
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}