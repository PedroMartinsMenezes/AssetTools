namespace AssetTool
{
    [JsonAsset("OptimusEditorGraphNode")]
    public class UOptimusEditorGraphNode : UEdGraphNode
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}