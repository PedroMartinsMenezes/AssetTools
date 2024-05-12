namespace AssetTool
{
    [Location("void UK2Node_EditablePinBase::Serialize(FArchive& Ar)")]
    public class UK2Node_FunctionTerminator : UK2Node_EditablePinBase
    {
        public new UK2Node_FunctionTerminator Move(Transfer transfer) => (UK2Node_FunctionTerminator)base.Move(transfer);
    }
}
