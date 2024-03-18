namespace AssetTool
{
    [Location("void FTextProperty::SerializeItem(FStructuredArchive::FSlot Slot, void* Value, void const* Defaults) const")]
    public class FTextProperty : FProperty
    {
        public const string TYPE_NAME = "TextProperty";
        public override string TypeName => TYPE_NAME;

        public new FTextProperty Read(BinaryReader reader)
        {
            base.Read(reader);
            return this;
        }
        public new void Write(BinaryWriter writer)
        {
            base.Write(writer);
        }
    }
}
