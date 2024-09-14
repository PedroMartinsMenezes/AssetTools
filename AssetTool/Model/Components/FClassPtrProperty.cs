namespace AssetTool
{
    [Location("void FClassPtrProperty::SerializeItem(FStructuredArchive::FSlot Slot, void* Value, void const* Defaults) const")]
    public class FClassPtrProperty : FClassProperty
    {
        public new const string TYPE_NAME = "ClassPtrProperty";
        public override string TypeName => TYPE_NAME;
    }
}
