namespace AssetTool
{
    [JsonAsset("OptimusEditorGraphNode")]
    public class UOptimusEditorGraphNode : UEdGraphNode
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}