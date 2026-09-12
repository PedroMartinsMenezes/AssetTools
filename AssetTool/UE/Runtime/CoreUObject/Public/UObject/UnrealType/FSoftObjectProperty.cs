namespace AssetTool
{
    [BaseEngineIni("+ClassRedirects=(OldName=\"AssetObjectProperty\",NewName=\"/Script/CoreUObject.SoftObjectProperty\")")]
    public class FSoftObjectProperty : FProperty
    {
        public new const string TYPE_NAME = "SoftObjectProperty";
        public const string OLD_TYPE_NAME = "AssetObjectProperty";
        public override string TypeName => TYPE_NAME;

        public UInt32 Value;
        public FSoftObjectPtr Ptr;

        [Location("void FSoftObjectProperty::SerializeItem( FStructuredArchive::FSlot Slot, void* Value, void const* Defaults ) const")]
        public override FField Move(Transfer transfer)
        {
            base.Move(transfer);
            transfer.Move(ref Value);
            return this;
        }

        [Location("EConvertFromTypeResult FObjectProperty::ConvertFromType(const FPropertyTag& Tag, FStructuredArchive::FSlot Slot, uint8* Data, UStruct* DefaultsStruct, const uint8* Defaults)")]
        public FField ConvertFromType(Transfer transfer)
        {
            transfer.Move(ref Ptr);
            return this;
        }

        public static FSoftObjectPtr MoveValue(Transfer transfer, FSoftObjectPtr value)
        {
            transfer.Move(ref value);
            return value;
        }
    }
}
