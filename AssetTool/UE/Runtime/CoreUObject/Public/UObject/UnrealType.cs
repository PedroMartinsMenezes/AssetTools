namespace AssetTool
{
    public class FLazyObjectProperty : FProperty
    {
        public new const string TYPE_NAME = "LazyObjectProperty";
        public override string TypeName => TYPE_NAME;

        public UInt32 Value;

        [Location("void FLazyObjectProperty::SerializeItem( FStructuredArchive::FSlot Slot, void* Value, void const* Defaults ) const")]
        public override FField Move(Transfer transfer)
        {
            base.Move(transfer);
            transfer.Move(ref Value);
            return this;
        }
    }
}
