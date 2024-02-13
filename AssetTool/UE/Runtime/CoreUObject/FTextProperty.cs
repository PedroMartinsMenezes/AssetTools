namespace AssetTool
{
    [Location("void FTextProperty::SerializeItem(FStructuredArchive::FSlot Slot, void* Value, void const* Defaults) const")]
    public class FTextProperty : FProperty
    {
        public const string TYPE_NAME = "TextProperty";
        public override string TypeName => TYPE_NAME;
    }

    public static class FTextPropertyExt
    {
        public static void Write(this BinaryWriter writer, FTextProperty item)
        {
            writer.Write((FProperty)item);
        }

        public static FTextProperty Read(this BinaryReader reader, FTextProperty item)
        {
            reader.Read((FProperty)item);
            return item;
        }
    }
}
