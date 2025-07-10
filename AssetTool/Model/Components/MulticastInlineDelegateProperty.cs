namespace AssetTool
{
    public class FMulticastInlineDelegateProperty : FProperty
    {
        public new const string TYPE_NAME = "MulticastInlineDelegateProperty";
        public override string TypeName => TYPE_NAME;

        public UInt32 PropertyValuePtr;
        public List<TScriptDelegate> InvocationList;

        public override FField Move(Transfer transfer)
        {
            base.Move(transfer);
            transfer.Move(ref PropertyValuePtr);
            return this;
        }

        [Location("void FMulticastInlineDelegateProperty::SerializeItem(FStructuredArchive::FSlot Slot, void* Value, void const* Defaults) const")]
        public FField SerializeItem(Transfer transfer)
        {
            transfer.Move(ref InvocationList);
            return this;
        }
    }
}
