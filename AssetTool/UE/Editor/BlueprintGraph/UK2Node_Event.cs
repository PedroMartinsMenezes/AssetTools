namespace AssetTool
{
    [Location("void UK2Node_Event::Serialize(FArchive& Ar)")]
    public class UK2Node_Event : UK2Node_EditablePinBase
    {
        public const string TypeName = "K2Node_Event";

        public new UK2Node_Event Move(Transfer transfer) => (UK2Node_Event)base.Move(transfer);
    }
}
