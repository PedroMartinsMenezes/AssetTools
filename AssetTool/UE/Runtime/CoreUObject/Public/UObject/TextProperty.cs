namespace AssetTool
{
    public class FTextProperty : FProperty
    {
        public new const string TYPE_NAME = "TextProperty";
        public override string TypeName => TYPE_NAME;

        [Location("void FTextProperty::SerializeItem(FStructuredArchive::FSlot Slot, void* Value, void const* Defaults) const")]
        public static FText MoveValue(Transfer transfer, FText value)
        {
            transfer.Move(ref value);
            return value;
        }
    }
}
