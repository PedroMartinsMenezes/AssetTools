namespace AssetTool
{
    [Location("void FMapProperty::SerializeItem(FStructuredArchive::FSlot Slot, void* Value, const void* Defaults)")]
    public class FMapProperty
    {
        public const string TYPE_NAME = "MapProperty";
        public string TypeName => TYPE_NAME;
        public static Dictionary<string, Func<Transfer, object>> ValueReaders { get; } = new();
        public static Dictionary<string, Func<Transfer, object, object>> ValueWriters { get; } = new();

        public Int32 NumKeysToRemove;
        public List<object> KeyProp = [];
        public List<object> ValueProp = [];

        static FMapProperty()
        {
            #region Readers
            ValueReaders.Add(FByteProperty.TYPE_NAME, (transfer) => new FByteProperty().MoveValue(transfer, 0));
            ValueReaders.Add(FDoubleProperty.TYPE_NAME, (transfer) => new FDoubleProperty().MoveValue(transfer, 0));
            ValueReaders.Add(FFloatProperty.TYPE_NAME, (transfer) => new FFloatProperty().MoveValue(transfer, 0));
            ValueReaders.Add(FInt16Property.TYPE_NAME, (transfer) => new FInt16Property().MoveValue(transfer, 0));
            ValueReaders.Add(FInt64Property.TYPE_NAME, (transfer) => new FInt64Property().MoveValue(transfer, 0));
            ValueReaders.Add(FInt8Property.TYPE_NAME, (transfer) => new FInt8Property().MoveValue(transfer, 0));
            ValueReaders.Add(FIntProperty.TYPE_NAME, (transfer) => new FIntProperty().MoveValue(transfer, 0));
            ValueReaders.Add(FUInt16Property.TYPE_NAME, (transfer) => new FUInt16Property().MoveValue(transfer, 0));
            ValueReaders.Add(FUInt32Property.TYPE_NAME, (transfer) => new FUInt32Property().MoveValue(transfer, 0));
            ValueReaders.Add(FUInt64Property.TYPE_NAME, (transfer) => new FUInt64Property().MoveValue(transfer, 0));
            #endregion

            #region Writers
            ValueWriters.Add(FByteProperty.TYPE_NAME, (transfer, value) => new FByteProperty().MoveValue(transfer, value.ToObject<byte>()));
            ValueWriters.Add(FDoubleProperty.TYPE_NAME, (transfer, value) => new FDoubleProperty().MoveValue(transfer, value.ToObject<double>()));
            ValueWriters.Add(FFloatProperty.TYPE_NAME, (transfer, value) => new FFloatProperty().MoveValue(transfer, value.ToObject<float>()));
            ValueWriters.Add(FInt16Property.TYPE_NAME, (transfer, value) => new FInt16Property().MoveValue(transfer, value.ToObject<Int16>()));
            ValueWriters.Add(FInt64Property.TYPE_NAME, (transfer, value) => new FInt64Property().MoveValue(transfer, value.ToObject<Int64>()));
            ValueWriters.Add(FInt8Property.TYPE_NAME, (transfer, value) => new FInt8Property().MoveValue(transfer, value.ToObject<sbyte>()));
            ValueWriters.Add(FIntProperty.TYPE_NAME, (transfer, value) => new FIntProperty().MoveValue(transfer, value.ToObject<int>()));
            ValueWriters.Add(FUInt16Property.TYPE_NAME, (transfer, value) => new FUInt16Property().MoveValue(transfer, value.ToObject<UInt16>()));
            ValueWriters.Add(FUInt32Property.TYPE_NAME, (transfer, value) => new FUInt32Property().MoveValue(transfer, value.ToObject<UInt32>()));
            ValueWriters.Add(FUInt64Property.TYPE_NAME, (transfer, value) => new FUInt64Property().MoveValue(transfer, value.ToObject<UInt64>()));
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
                else if (keyType == FObjectPropertyBase.TYPE_NAME)
                    KeyProp.Add(reader.ReadUInt32());
                else if (name == "AttributeCurves")
                    KeyProp.Add(new FAnimationAttributeIdentifier().Move(GlobalObjects.Transfer)); //@@@ Hardcoded
                else
                    throw new InvalidOperationException($"Invalid Map Key: {keyType}");

                if (name.Contains(Consts.Guid))
                    ValueProp.Add(reader.ReadFGuid());
                else if (ValueReaders.ContainsKey(valueType))
                    ValueProp.Add(ValueReaders[valueType](GlobalObjects.Transfer));
                else if (name == "AttributeCurves")
                    ValueProp.Add(new FAttributeCurve().Move(GlobalObjects.Transfer)); //@@@ Hardcoded
                else
                    ValueProp.Add(GlobalObjects.Transfer.MoveTags([], indent));

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
                else if (keyType == FObjectPropertyBase.TYPE_NAME)
                    writer.Write(KeyProp[i].ToObject<UInt32>());
                else if (name == "AttributeCurves")
                    KeyProp[i].ToObject<FAnimationAttributeIdentifier>().Move(GlobalObjects.Transfer); //@@@ Hardcoded

                if (name.Contains(Consts.Guid))
                    writer.WriteFGuid(ValueProp[i].ToObject<FGuid>());
                else if (ValueWriters.ContainsKey(valueType))
                    ValueWriters[valueType](GlobalObjects.Transfer, ValueProp[i]);
                else if (name == "AttributeCurves")
                    ValueProp[i].ToObject<FAttributeCurve>().Move(GlobalObjects.Transfer); //@@@ Hardcoded
                else
                    GlobalObjects.Transfer.MoveTags(ValueProp[i].ToObject<List<object>>(), indent);
            }
        }
    }
}


