namespace AssetTool
{
    [JsonAsset("PCGEditorGraphSchema")]
    public class UPCGEditorGraphSchema : UEdGraphSchema
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}