namespace AssetTool
{
    [JsonAsset("PCGEditorGraphSchema")]
    public class UPCGEditorGraphSchema : UEdGraphSchema
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}