namespace AssetTool
{
    [Location("void FTextProperty::SerializeItem(FStructuredArchive::FSlot Slot, void* Value, void const* Defaults) const")]
    public class FTextProperty : FProperty
    {
        public new const string TYPE_NAME = "TextProperty";
        public override string TypeName => TYPE_NAME;
    }
}
