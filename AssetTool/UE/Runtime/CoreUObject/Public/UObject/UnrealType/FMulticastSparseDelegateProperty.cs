namespace AssetTool
{
    using FMulticastScriptDelegate = TMulticastScriptDelegate;

    public class FMulticastSparseDelegateProperty : FProperty
    {
        public new const string TYPE_NAME = "MulticastSparseDelegateProperty";
        public override string TypeName => TYPE_NAME;

        public FMulticastScriptDelegate Delegate;

        [Location("void FMulticastSparseDelegateProperty::SerializeItem(FStructuredArchive::FSlot Slot, void* Value, void const* Defaults) const")]
        public FMulticastSparseDelegateProperty SerializeItem(Transfer transfer)
        {
            transfer.Move(ref Delegate);
            return this;
        }
    }
}
