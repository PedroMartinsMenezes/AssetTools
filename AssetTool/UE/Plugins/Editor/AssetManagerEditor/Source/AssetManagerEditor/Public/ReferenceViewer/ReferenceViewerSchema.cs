namespace AssetTool
{
    [JsonAsset("ReferenceViewerSchema")]
    public class UReferenceViewerSchema : UEdGraphSchema
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}