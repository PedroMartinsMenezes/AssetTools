namespace AssetTool
{
    [Location("void UK2Node_EditablePinBase::Serialize(FArchive& Ar)")]
    public class UK2Node_FunctionResult : UK2Node_FunctionTerminator
    {
        public const string TypeName = "K2Node_FunctionResult";

        public new UK2Node_FunctionResult Move(Transfer transfer) => (UK2Node_FunctionResult)base.Move(transfer);
    }
}
