namespace AssetTool
{
    [Location("void FMapProperty::SerializeItem(FStructuredArchive::FSlot Slot, void* Value, const void* Defaults)")]
    public class FMapProperty //: FMapProperty_Super
    {
        public const string TYPE_NAME = "MapProperty";
        public string TypeName => TYPE_NAME;

        public Int32 NumKeysToRemove;
        public List<UInt32> KeyProp = [];
        public List<object> ValueProp = [];

        public FMapProperty Read(BinaryReader reader, int indent)
        {
            reader.Read(ref NumKeysToRemove);
            if (NumKeysToRemove > 0)
            {
                throw new NotImplementedException();
            }
            int count = reader.ReadInt32();
            while (count-- > 0)
            {
                KeyProp.Add(reader.ReadUInt32());
                reader.ReadTags(ValueProp, indent + 2);
            }
            return this;
        }
        public void Write(BinaryWriter writer)
        {
            writer.Write(NumKeysToRemove);
            if (NumKeysToRemove > 0)
            {
                throw new NotImplementedException();
            }
            writer.Write(KeyProp.Count);
            for (int i = 0; i < KeyProp.Count; i++)
            {
                writer.Write(KeyProp[i]);
                writer.WriteTags(ValueProp);
            }
        }
    }
}
