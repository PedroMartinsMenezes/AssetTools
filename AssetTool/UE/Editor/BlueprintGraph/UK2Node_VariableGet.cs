namespace AssetTool
{
    [Location("void UK2Node::Serialize(FArchive& Ar)")]
    public class UK2Node_VariableGet : UK2Node_Variable
    {
        public new const string TypeName = "K2Node_VariableGet";

        public new UK2Node_VariableGet Move(Transfer transfer) => (UK2Node_VariableGet)base.Move(transfer);
    }
}
