namespace AssetTool
{
    [JsonAsset("OptimusEditorGraphNode")]
    public class UOptimusEditorGraphNode : UEdGraphNode
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}