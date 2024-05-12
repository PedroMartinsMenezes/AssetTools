namespace AssetTool
{
    [Location("void UK2Node::Serialize(FArchive& Ar)")]
    public class UK2Node_IfThenElse : UK2Node
    {
        public const string TypeName = "K2Node_IfThenElse";

        public new UK2Node_IfThenElse Move(Transfer transfer) => (UK2Node_IfThenElse)base.Move(transfer);
    }
}
