namespace AssetTool
{
    public class FSetProperty : FProperty
    {
        public new const string TYPE_NAME = "SetProperty";
        public override string TypeName => TYPE_NAME;

        #region Serialize
        public FName PropertyTypeName;
        public FField SingleField;
        #endregion

        #region SerializeItem
        public Int32 NumElementsToRemove;
        public Int32 Num;
        public List<object> Values;
        #endregion

        #region Serialize
        [Location("void FSetProperty::Serialize( FArchive& Ar )")]
        public override FField Move(Transfer transfer)
        {
            base.Move(transfer);
            SerializeSingleField(transfer);
            return this;
        }

        [Location("inline void SerializeSingleField(FArchive& Ar, FieldType*& Field, FFieldVariant Owner)")]
        private void SerializeSingleField(Transfer transfer)
        {
            transfer.Move(ref PropertyTypeName);
            if (PropertyTypeName.IsFilled)
            {
                if (Transfers.ContainsKey(PropertyTypeName.Value))
                {
                    SingleField = SingleField ?? UStruct.GetNameToFieldClassMap(transfer, PropertyTypeName);
                    SingleField.Move(transfer);
                }
            }
        }
        #endregion

        #region SerializeItem
        [Location("void FSetProperty::SerializeItem(FStructuredArchive::FSlot Slot, void* Value, const void* Defaults)")]
        public FField MoveValue(Transfer transfer, string name, string valueType, string keyType, int indent)
        {
            transfer.Move(ref NumElementsToRemove);
            transfer.Move(ref Num);
            Values = Values.Resize(transfer, Num, true);
            AddItems(transfer, name, valueType, keyType, indent);
            return this;
        }

        [Location("void FWeakObjectProperty::SerializeItem( FStructuredArchive::FSlot Slot, void* Value, void const* Defaults )")]
        private void AddItems(Transfer transfer, string name, string valueType, string keyType, int indent)
        {
            for (var i = 0; i < Num; i++)
            {
                if (Transfers.ContainsKey(keyType))
                    Values[i] = Transfers[keyType](transfer, Values[i]);
                else if (keyType == FStructProperty.TYPE_NAME)
                    Values[i] = transfer.MoveTags(Values[i].ToObject<List<object>>(), indent);
                else
                    throw new InvalidOperationException($"Invalid Type : {keyType}");
            }
        }
        #endregion

        static FSetProperty()
        {
            Transfers.Add(FBoolProperty.TYPE_NAME, (transfer, value) => FBoolProperty.MoveValue(transfer, value.ToObject<byte>()));
            Transfers.Add(FByteProperty.TYPE_NAME, (transfer, value) => FByteProperty.MoveValue(transfer, value.ToObject<byte>()));
            Transfers.Add(FDoubleProperty.TYPE_NAME, (transfer, value) => FDoubleProperty.MoveValue(transfer, value.ToObject<double>()));
            Transfers.Add(FFloatProperty.TYPE_NAME, (transfer, value) => FFloatProperty.MoveValue(transfer, value.ToObject<float>()));
            Transfers.Add(FInt16Property.TYPE_NAME, (transfer, value) => FInt16Property.MoveValue(transfer, value.ToObject<Int16>()));
            Transfers.Add(FInt64Property.TYPE_NAME, (transfer, value) => FInt64Property.MoveValue(transfer, value.ToObject<Int64>()));
            Transfers.Add(FInt8Property.TYPE_NAME, (transfer, value) => FInt8Property.MoveValue(transfer, value.ToObject<sbyte>()));
            Transfers.Add(FIntProperty.TYPE_NAME, (transfer, value) => FIntProperty.MoveValue(transfer, value.ToObject<int>()));
            Transfers.Add(FNameProperty.TYPE_NAME, (transfer, value) => FNameProperty.MoveValue(transfer, value.ToObject<FName>()));
            Transfers.Add(FStrProperty.TYPE_NAME, (transfer, value) => FStrProperty.MoveValue(transfer, value.ToObject<FString>()));
            Transfers.Add(FTextProperty.TYPE_NAME, (transfer, value) => FTextProperty.MoveValue(transfer, value.ToObject<FText>()));
            Transfers.Add(FUInt16Property.TYPE_NAME, (transfer, value) => FUInt16Property.MoveValue(transfer, value.ToObject<UInt16>()));
            Transfers.Add(FUInt32Property.TYPE_NAME, (transfer, value) => FUInt32Property.MoveValue(transfer, value.ToObject<UInt32>()));
            Transfers.Add(FUInt64Property.TYPE_NAME, (transfer, value) => FUInt64Property.MoveValue(transfer, value.ToObject<UInt64>()));
            Transfers.Add(FObjectPropertyBase.TYPE_NAME, (transfer, value) => FObjectPropertyBase.MoveValue(transfer, value.ToObject<UInt32>()));
            Transfers.Add(FObjectProperty.TYPE_NAME, (transfer, value) => FObjectProperty.MoveValue(transfer, value.ToObject<UInt32>()));
        }

        public static Dictionary<string, Func<Transfer, object, object>> Transfers { get; } = new();
    }
}
