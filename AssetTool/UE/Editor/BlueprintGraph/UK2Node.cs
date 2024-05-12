namespace AssetTool
{
    [Location("void UK2Node::Serialize(FArchive& Ar)")]
    public class UK2Node : UEdGraphNode
    {
        public new UK2Node Move(Transfer transfer) => (UK2Node)base.Move(transfer);
    }
}
