namespace AssetTool
{
    [JsonAsset("PCGEditorGraphNodeBase")]
    public class UPCGEditorGraphNodeBase : UEdGraphNode
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}