namespace AssetTool
{
    public class FInterfaceProperty : FProperty
    {
        public new const string TYPE_NAME = "InterfaceProperty";
        public override string TypeName => TYPE_NAME;

        public UInt32 Value;

        [Location("void FInterfaceProperty::Serialize( FArchive& Ar )")]
        public override FField Move(Transfer transfer)
        {
            base.Move(transfer);
            transfer.Move(ref Value);
            return this;
        }

        [Location("EConvertFromTypeResult FObjectProperty::ConvertFromType(const FPropertyTag& Tag, FStructuredArchive::FSlot Slot, uint8* Data, UStruct* DefaultsStruct, const uint8* Defaults)")]
        public FField ConvertFromType(Transfer transfer)
        {
            transfer.Move(ref Value);
            return this;
        }
    }
}
