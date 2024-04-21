namespace AssetTool
{
    [Location("void FMapProperty::SerializeItem(FStructuredArchive::FSlot Slot, void* Value, const void* Defaults)")]
    public class FMapProperty
    {
        public const string TYPE_NAME = "MapProperty";
        public string TypeName => TYPE_NAME;
        public static Dictionary<string, Func<BinaryReader, object>> ValueReaders { get; } = new();
        public static Dictionary<string, Action<BinaryWriter, object>> ValueWriters { get; } = new();

        public Int32 NumKeysToRemove;
        public List<object> KeyProp = [];
        public List<object> ValueProp = [];

        static FMapProperty()
        {
            #region Readers
            ValueReaders.Add(FByteProperty.TYPE_NAME, (reader) => FByteProperty.ReadValue(reader));
            ValueReaders.Add(FDoubleProperty.TYPE_NAME, (reader) => FDoubleProperty.ReadValue(reader));
            ValueReaders.Add(FFloatProperty.TYPE_NAME, (reader) => FFloatProperty.ReadValue(reader));
            ValueReaders.Add(FInt16Property.TYPE_NAME, (reader) => FInt16Property.ReadValue(reader));
            ValueReaders.Add(FInt64Property.TYPE_NAME, (reader) => FInt64Property.ReadValue(reader));
            ValueReaders.Add(FInt8Property.TYPE_NAME, (reader) => FInt8Property.ReadValue(reader));
            ValueReaders.Add(FIntProperty.TYPE_NAME, (reader) => FIntProperty.ReadValue(reader));
            ValueReaders.Add(FUInt16Property.TYPE_NAME, (reader) => FUInt16Property.ReadValue(reader));
            ValueReaders.Add(FUInt32Property.TYPE_NAME, (reader) => FUInt32Property.ReadValue(reader));
            ValueReaders.Add(FUInt64Property.TYPE_NAME, (reader) => FUInt64Property.ReadValue(reader));
            #endregion

            #region Writers
            ValueWriters.Add(FByteProperty.TYPE_NAME, (writer, value) => FByteProperty.WriteValue(writer, value.ToObject<byte>()));
            ValueWriters.Add(FDoubleProperty.TYPE_NAME, (writer, value) => FDoubleProperty.WriteValue(writer, value.ToObject<double>()));
            ValueWriters.Add(FFloatProperty.TYPE_NAME, (writer, value) => FFloatProperty.WriteValue(writer, value.ToObject<float>()));
            ValueWriters.Add(FInt16Property.TYPE_NAME, (writer, value) => FInt16Property.WriteValue(writer, value.ToObject<Int16>()));
            ValueWriters.Add(FInt64Property.TYPE_NAME, (writer, value) => FInt64Property.WriteValue(writer, value.ToObject<Int64>()));
            ValueWriters.Add(FInt8Property.TYPE_NAME, (writer, value) => FInt8Property.WriteValue(writer, value.ToObject<sbyte>()));
            ValueWriters.Add(FIntProperty.TYPE_NAME, (writer, value) => FIntProperty.WriteValue(writer, value.ToObject<Int32>()));
            ValueWriters.Add(FUInt16Property.TYPE_NAME, (writer, value) => FUInt16Property.WriteValue(writer, value.ToObject<UInt16>()));
            ValueWriters.Add(FUInt32Property.TYPE_NAME, (writer, value) => FUInt32Property.WriteValue(writer, value.ToObject<UInt32>()));
            ValueWriters.Add(FUInt64Property.TYPE_NAME, (writer, value) => FUInt64Property.WriteValue(writer, value.ToObject<UInt64>()));
            #endregion
        }

        public FMapProperty Read(BinaryReader reader, string name, string valueType, string keyType, int indent)
        {
            reader.Read(ref NumKeysToRemove);
            if (NumKeysToRemove > 0)
            {
                throw new NotImplementedException();
            }
            int NumEntries = reader.ReadInt32();
            for (int i = 0; i < NumEntries; i++)
            {
                if (keyType == FNameProperty.TYPE_NAME)
                    KeyProp.Add(reader.ReadFName());
                else if (keyType == FUInt32Property.TYPE_NAME)
                    KeyProp.Add(reader.ReadUInt32());
                else
                    throw new InvalidOperationException($"Invalid Map Key: {keyType}");

                if (name.Contains(Consts.Guid))
                    ValueProp.Add(reader.ReadFGuid());
                else if (ValueReaders.ContainsKey(valueType))
                    ValueProp.Add(ValueReaders[valueType](reader));
                else
                    ValueProp.Add(reader.ReadTags([], indent));
            }
            return this;
        }
        public void Write(BinaryWriter writer, string name, string valueType, string keyType, int indent)
        {
            writer.Write(NumKeysToRemove);
            if (NumKeysToRemove > 0)
            {
                throw new NotImplementedException();
            }
            writer.Write(KeyProp.Count);
            for (int i = 0; i < KeyProp.Count; i++)
            {
                if (keyType == FNameProperty.TYPE_NAME)
                    writer.Write(KeyProp[i].ToObject<FName>());
                else if (keyType == FUInt32Property.TYPE_NAME)
                    writer.Write(KeyProp[i].ToObject<UInt32>());

                if (name.Contains(Consts.Guid))
                    writer.WriteFGuid(ValueProp[i].ToObject<FGuid>());
                else if (ValueWriters.ContainsKey(valueType))
                    ValueWriters[valueType](writer, ValueProp[i]);
                else
                    writer.WriteTags(ValueProp[i].ToObject<List<object>>(), indent);

            }
        }
    }
}


