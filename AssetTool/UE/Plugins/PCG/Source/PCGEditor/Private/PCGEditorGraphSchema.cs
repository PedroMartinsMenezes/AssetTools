namespace AssetTool
{
    [JsonAsset("PCGEditorGraphSchema")]
    public class UPCGEditorGraphSchema : UEdGraphSchema
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}