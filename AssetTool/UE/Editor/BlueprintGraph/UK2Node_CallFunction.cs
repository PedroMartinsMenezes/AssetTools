namespace AssetTool
{
    [Location("void UK2Node_CallFunction::Serialize(FArchive& Ar)")]
    public class UK2Node_CallFunction : UK2Node
    {
        public const string TypeName = "K2Node_CallFunction";

        public new UK2Node_CallFunction Move(Transfer transfer) => (UK2Node_CallFunction)base.Move(transfer);
    }
}
