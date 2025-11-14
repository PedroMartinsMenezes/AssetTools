namespace AssetTool
{
    [JsonAsset("ReferenceViewerSchema")]
    public class UReferenceViewerSchema : UEdGraphSchema
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}