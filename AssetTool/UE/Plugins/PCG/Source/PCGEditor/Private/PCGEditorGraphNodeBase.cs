namespace AssetTool
{
    [JsonAsset("PCGEditorGraphNodeBase")]
    public class UPCGEditorGraphNodeBase : UEdGraphNode
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}