namespace AssetTool
{
    public class UEdGraphNode_Comment : UEdGraphNode
    {
        public const string TypeName = "EdGraphNode_Comment";

        public new UEdGraphNode_Comment Move(Transfer transfer) => (UEdGraphNode_Comment)base.Move(transfer);
    }
}
