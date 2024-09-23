namespace AssetTool
{
    [Location("void FMapProperty::SerializeItem(FStructuredArchive::FSlot Slot, void* Value, const void* Defaults)")]
    public class FMapProperty : FProperty
    {
        public new const string TYPE_NAME = "MapProperty";
        public override string TypeName => TYPE_NAME;
        public static Dictionary<string, Func<Transfer, object>> ValueReaders { get; } = new();
        public static Dictionary<string, Func<Transfer, object, object>> ValueWriters { get; } = new();

        public static Dictionary<string, Func<Transfer, object>> KeyReaders { get; } = new();
        public static Dictionary<string, Func<Transfer, object, object>> KeyWriters { get; } = new();

        public static Dictionary<string, Func<Transfer, object>> PropReaders { get; } = new();
        public static Dictionary<string, Func<Transfer, object, object>> PropWriters { get; } = new();

        public Int32 NumKeysToRemove;
        public List<object> KeyProp = [];
        public List<object> ValueProp = [];

        public FName PropertyTypeName1;
        public FField SingleField1;
        public FName PropertyTypeName2;
        public FField SingleField2;


        ///C++
        ///void FMapProperty::Serialize( FArchive& Ar )
        ///{
        ///    Super::Serialize( Ar );
        ///
        ///    SerializeSingleField(Ar, KeyProp, this);
        ///    SerializeSingleField(Ar, ValueProp, this);
        ///}


        ///C#
        ///public override FField Move(Transfer transfer)
        ///{
        ///    base.Move(transfer);
        ///    SerializeSingleField(transfer, KeyProp, this);
        ///    SerializeSingleField(transfer, ValueProp, this);
        ///    return this;
        ///}

        public override FField Move(Transfer transfer)
        {
            base.Move(transfer);
            SerializeSingleField1(transfer);
            SerializeSingleField2(transfer);
            return this;
        }

        private void SerializeSingleField1(Transfer transfer)
        {
            transfer.Move(ref PropertyTypeName1);
            if (PropertyTypeName1.IsFilled)
            {
                SingleField1 = SingleField1 ?? UStruct.GetNameToFieldClassMap(transfer, PropertyTypeName1);
                SingleField1.Move(transfer);
            }
        }

        private void SerializeSingleField2(Transfer transfer)
        {
            transfer.Move(ref PropertyTypeName2);
            if (PropertyTypeName2.IsFilled)
            {
                SingleField2 = SingleField2 ?? UStruct.GetNameToFieldClassMap(transfer, PropertyTypeName2);
                SingleField2.Move(transfer);
            }
        }

        [Location("void FMapProperty::SerializeItem(FStructuredArchive::FSlot Slot, void* Value, const void* Defaults) const")]
        public FMapProperty Read(BinaryReader reader, string name, string valueType, string keyType, int indent)
        {
            reader.Read(ref NumKeysToRemove);
            int NumEntries = reader.ReadInt32();
            for (int i = 0; i < NumEntries; i++)
            {
                if (ValueReaders.ContainsKey(keyType))
                    KeyProp.Add(ValueReaders[keyType](GlobalObjects.Transfer));
                else if (KeyReaders.ContainsKey(name))
                    KeyProp.Add(KeyReaders[name](GlobalObjects.Transfer));
                else
                    throw new InvalidOperationException($"Invalid Map Key: {keyType}");

                if (name.Contains(Consts.Guid))
                    ValueProp.Add(reader.ReadFGuid());
                else if (ValueReaders.ContainsKey(valueType))
                    ValueProp.Add(ValueReaders[valueType](GlobalObjects.Transfer));
                else if (PropReaders.ContainsKey(name))
                    ValueProp.Add(PropReaders[name](GlobalObjects.Transfer));
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
                if (ValueWriters.ContainsKey(keyType))
                    ValueWriters[keyType](GlobalObjects.Transfer, KeyProp[i]);
                else if (KeyWriters.ContainsKey(name))
                    KeyWriters[name](GlobalObjects.Transfer, KeyProp[i]);
                else
                    throw new InvalidOperationException($"Invalid Map Key: {keyType}");

                if (name.Contains(Consts.Guid))
                    writer.WriteFGuid(ValueProp[i].ToObject<FGuid>());
                else if (ValueWriters.ContainsKey(valueType))
                    ValueWriters[valueType](GlobalObjects.Transfer, ValueProp[i]);
                else if (PropWriters.ContainsKey(name))
                    PropWriters[name](GlobalObjects.Transfer, ValueProp[i]);
                else
                    GlobalObjects.Transfer.MoveTags(ValueProp[i].ToObject<List<object>>(), indent);
            }
        }

        static FMapProperty()
        {
            #region Readers
            ValueReaders.Add(FBoolProperty.TYPE_NAME, (transfer) => FBoolProperty.MoveValue(transfer, new byte()));
            ValueReaders.Add(FByteProperty.TYPE_NAME, (transfer) => FByteProperty.MoveValue(transfer, 0));
            ValueReaders.Add(FDoubleProperty.TYPE_NAME, (transfer) => FDoubleProperty.MoveValue(transfer, 0));
            ValueReaders.Add(FFloatProperty.TYPE_NAME, (transfer) => FFloatProperty.MoveValue(transfer, 0));
            ValueReaders.Add(FInt16Property.TYPE_NAME, (transfer) => FInt16Property.MoveValue(transfer, 0));
            ValueReaders.Add(FInt64Property.TYPE_NAME, (transfer) => FInt64Property.MoveValue(transfer, 0));
            ValueReaders.Add(FInt8Property.TYPE_NAME, (transfer) => FInt8Property.MoveValue(transfer, 0));
            ValueReaders.Add(FIntProperty.TYPE_NAME, (transfer) => FIntProperty.MoveValue(transfer, 0));
            ValueReaders.Add(FNameProperty.TYPE_NAME, (transfer) => FNameProperty.MoveValue(transfer, new FName()));
            ValueReaders.Add(FStrProperty.TYPE_NAME, (transfer) => FStrProperty.MoveValue(transfer, new FString()));
            ValueReaders.Add(FTextProperty.TYPE_NAME, (transfer) => FTextProperty.MoveValue(transfer, new FText()));
            ValueReaders.Add(FUInt16Property.TYPE_NAME, (transfer) => FUInt16Property.MoveValue(transfer, 0));
            ValueReaders.Add(FUInt32Property.TYPE_NAME, (transfer) => FUInt32Property.MoveValue(transfer, 0));
            ValueReaders.Add(FUInt64Property.TYPE_NAME, (transfer) => FUInt64Property.MoveValue(transfer, 0));
            ValueReaders.Add(FObjectPropertyBase.TYPE_NAME, (transfer) => FObjectPropertyBase.MoveValue(transfer, 0));
            ValueReaders.Add(FObjectProperty.TYPE_NAME, (transfer) => FObjectProperty.MoveValue(transfer, 0));
            #endregion

            #region Key Readers Hard Coded
            KeyReaders.Add("AttributeCurves", (transfer) => new FAnimationAttributeIdentifier().Move(transfer));
            #endregion

            #region Prop Readers Hard Coded
            PropReaders.Add("AttributeCurves", (transfer) => new FAttributeCurve().Move(transfer));
            #endregion

            #region Writers
            ValueWriters.Add(FBoolProperty.TYPE_NAME, (transfer, value) => FBoolProperty.MoveValue(transfer, value.ToObject<byte>()));
            ValueWriters.Add(FByteProperty.TYPE_NAME, (transfer, value) => FByteProperty.MoveValue(transfer, value.ToObject<byte>()));
            ValueWriters.Add(FDoubleProperty.TYPE_NAME, (transfer, value) => FDoubleProperty.MoveValue(transfer, value.ToObject<double>()));
            ValueWriters.Add(FFloatProperty.TYPE_NAME, (transfer, value) => FFloatProperty.MoveValue(transfer, value.ToObject<float>()));
            ValueWriters.Add(FInt16Property.TYPE_NAME, (transfer, value) => FInt16Property.MoveValue(transfer, value.ToObject<Int16>()));
            ValueWriters.Add(FInt64Property.TYPE_NAME, (transfer, value) => FInt64Property.MoveValue(transfer, value.ToObject<Int64>()));
            ValueWriters.Add(FInt8Property.TYPE_NAME, (transfer, value) => FInt8Property.MoveValue(transfer, value.ToObject<sbyte>()));
            ValueWriters.Add(FIntProperty.TYPE_NAME, (transfer, value) => FIntProperty.MoveValue(transfer, value.ToObject<int>()));
            ValueWriters.Add(FNameProperty.TYPE_NAME, (transfer, value) => FNameProperty.MoveValue(transfer, value.ToObject<FName>()));
            ValueWriters.Add(FStrProperty.TYPE_NAME, (transfer, value) => FStrProperty.MoveValue(transfer, value.ToObject<FString>()));
            ValueWriters.Add(FTextProperty.TYPE_NAME, (transfer, value) => FTextProperty.MoveValue(transfer, value.ToObject<FText>()));
            ValueWriters.Add(FUInt16Property.TYPE_NAME, (transfer, value) => FUInt16Property.MoveValue(transfer, value.ToObject<UInt16>()));
            ValueWriters.Add(FUInt32Property.TYPE_NAME, (transfer, value) => FUInt32Property.MoveValue(transfer, value.ToObject<UInt32>()));
            ValueWriters.Add(FUInt64Property.TYPE_NAME, (transfer, value) => FUInt64Property.MoveValue(transfer, value.ToObject<UInt64>()));
            ValueWriters.Add(FObjectPropertyBase.TYPE_NAME, (transfer, value) => FObjectPropertyBase.MoveValue(transfer, value.ToObject<UInt32>()));
            ValueWriters.Add(FObjectProperty.TYPE_NAME, (transfer, value) => FObjectProperty.MoveValue(transfer, value.ToObject<UInt32>()));
            #endregion

            #region Key Writers Hard Coded
            KeyWriters.Add("AttributeCurves", (transfer, value) => value.ToObject<FAnimationAttributeIdentifier>().Move(transfer));
            #endregion

            #region Prop Writers Hard Coded
            PropWriters.Add("AttributeCurves", (transfer, value) => value.ToObject<FAttributeCurve>().Move(transfer));
            #endregion
        }
    }
}


