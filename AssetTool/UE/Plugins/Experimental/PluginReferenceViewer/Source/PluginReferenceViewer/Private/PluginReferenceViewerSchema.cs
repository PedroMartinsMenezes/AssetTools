namespace AssetTool
{
    [JsonAsset("PluginReferenceViewerSchema")]
    public class UPluginReferenceViewerSchema : UEdGraphSchema
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}