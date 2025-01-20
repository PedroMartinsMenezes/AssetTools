namespace AssetTool
{
    public class FMapProperty : FProperty
    {
        public new const string TYPE_NAME = "MapProperty";
        public override string TypeName => TYPE_NAME;
        public static Dictionary<string, Func<Transfer, object, object>> ValueMovers { get; } = new();
        public static Dictionary<string, Func<Transfer, object, object>> KeyMovers { get; } = new();
        public static Dictionary<string, Func<Transfer, object, object>> PropMovers { get; } = new();

        #region Serialize
        public FName PropertyTypeName1;
        public FField SingleField1;
        public FName PropertyTypeName2;
        public FField SingleField2;
        #endregion

        #region SerializeItem
        public Int32 NumKeysToRemove;
        public Int32 NumEntries;
        public List<object> KeyProp = [];
        public List<object> ValueProp = [];
        #endregion

        #region Serialize
        [Location("void FMapProperty::Serialize( FArchive& Ar )")]
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
        #endregion

        #region SerializeItem
        [Location("void FMapProperty::SerializeItem(FStructuredArchive::FSlot Slot, void* Value, const void* Defaults) const")]
        public FMapProperty MoveValue(Transfer transfer, string name, string valueType, string keyType, int indent)
        {
            transfer.Move(ref NumKeysToRemove);
            transfer.Move(ref NumEntries);
            KeyProp.Resize(transfer, NumEntries, true);
            ValueProp.Resize(transfer, NumEntries, true);
            try
            {

                for (int i = 0; i < NumEntries; i++)
                {
                    if (ValueMovers.ContainsKey(keyType))
                        KeyProp[i] = ValueMovers[keyType](transfer, KeyProp[i]);
                    else if (KeyMovers.ContainsKey(name))
                        KeyProp[i] = KeyMovers[name](transfer, KeyProp[i]);
                    else
                        throw new InvalidOperationException($"Invalid Map Key: {keyType}");

                    if (ValueMovers.ContainsKey(valueType))
                        ValueProp[i] = ValueMovers[valueType](transfer, ValueProp[i]);
                    else if (PropMovers.ContainsKey(name))
                        ValueProp[i] = PropMovers[name](transfer, ValueProp[i]);
                    else
                        ValueProp[i] = transfer.MoveTags(ValueProp[i].ToObject<List<object>>(), indent);
                }
            }
            catch
            {
                Log.Error($"FMapProperty Failed. Name({name}) ValueType({valueType}) KeyType({keyType})");
                throw;
            }
            return this;
        }
        #endregion

        static FMapProperty()
        {
            //Values
            ValueMovers.Add(FGuid.TYPE_NAME, (transfer, value) => FGuid.MoveValue(transfer, value.ToObject<FGuid>()));
            ValueMovers.Add(FBoolProperty.TYPE_NAME, (transfer, value) => FBoolProperty.MoveValue(transfer, value.ToObject<byte>()));
            ValueMovers.Add(FByteProperty.TYPE_NAME, (transfer, value) => FByteProperty.MoveValue(transfer, value.ToObject<byte>()));
            ValueMovers.Add(FDoubleProperty.TYPE_NAME, (transfer, value) => FDoubleProperty.MoveValue(transfer, value.ToObject<double>()));
            ValueMovers.Add(FFloatProperty.TYPE_NAME, (transfer, value) => FFloatProperty.MoveValue(transfer, value.ToObject<float>()));
            ValueMovers.Add(FInt16Property.TYPE_NAME, (transfer, value) => FInt16Property.MoveValue(transfer, value.ToObject<Int16>()));
            ValueMovers.Add(FInt64Property.TYPE_NAME, (transfer, value) => FInt64Property.MoveValue(transfer, value.ToObject<Int64>()));
            ValueMovers.Add(FInt8Property.TYPE_NAME, (transfer, value) => FInt8Property.MoveValue(transfer, value.ToObject<sbyte>()));
            ValueMovers.Add(FIntProperty.TYPE_NAME, (transfer, value) => FIntProperty.MoveValue(transfer, value.ToObject<int>()));
            ValueMovers.Add(FNameProperty.TYPE_NAME, (transfer, value) => FNameProperty.MoveValue(transfer, value.ToObject<FName>()));
            ValueMovers.Add(FStrProperty.TYPE_NAME, (transfer, value) => FStrProperty.MoveValue(transfer, value.ToObject<FString>()));
            ValueMovers.Add(FTextProperty.TYPE_NAME, (transfer, value) => FTextProperty.MoveValue(transfer, value.ToObject<FText>()));
            ValueMovers.Add(FUInt16Property.TYPE_NAME, (transfer, value) => FUInt16Property.MoveValue(transfer, value.ToObject<UInt16>()));
            ValueMovers.Add(FUInt32Property.TYPE_NAME, (transfer, value) => FUInt32Property.MoveValue(transfer, value.ToObject<UInt32>()));
            ValueMovers.Add(FUInt64Property.TYPE_NAME, (transfer, value) => FUInt64Property.MoveValue(transfer, value.ToObject<UInt64>()));
            ValueMovers.Add(FObjectPropertyBase.TYPE_NAME, (transfer, value) => FObjectPropertyBase.MoveValue(transfer, value.ToObject<UInt32>()));
            ValueMovers.Add(FObjectProperty.TYPE_NAME, (transfer, value) => FObjectProperty.MoveValue(transfer, value.ToObject<UInt32>()));

            //Keys (Mistery)            
            KeyMovers.Add("AttributeCurves", (transfer, value) => value.ToObject<FAnimationAttributeIdentifier>().Move(transfer));
            KeyMovers.Add("UserParameterRedirects", (transfer, value) => value.ToObject<FNiagaraVariable>().Move(transfer));
            KeyMovers.Add("VariableToScriptVariable", (transfer, value) => value.ToObject<FNiagaraVariable>().Move(transfer));
            KeyMovers.Add("BoundPinNames", (transfer, value) => FGuid.MoveValue(transfer, value.ToObject<FGuid>()));
            KeyMovers.Add("PinOutputToPinDefaultPersistentId", (transfer, value) => FGuid.MoveValue(transfer, value.ToObject<FGuid>()));
            KeyMovers.Add("Locations", (transfer, value) => FGuid.MoveValue(transfer, value.ToObject<FGuid>()));
            KeyMovers.Add("LayersData", (transfer, value) => FGuid.MoveValue(transfer, value.ToObject<FGuid>()));
            KeyMovers.Add("ParameterGuidMapping", (transfer, value) => value.ToObject<FNiagaraVariable>().Move(transfer));
            KeyMovers.Add("InputDescriptions", (transfer, value) => value.ToObject<FNiagaraVariableBase>().Move(transfer));
            KeyMovers.Add("OutputDescriptions", (transfer, value) => value.ToObject<FNiagaraVariableBase>().Move(transfer));
            KeyMovers.Add("Dependencies", (transfer, value) => transfer.MoveTags(value.ToObject<List<object>>()));

            //Props (Mistery)
            PropMovers.Add("AttributeCurves", (transfer, value) => value.ToObject<FAttributeCurve>().Move(transfer));
            PropMovers.Add("UserParameterRedirects", (transfer, value) => value.ToObject<FNiagaraVariable>().Move(transfer));
            PropMovers.Add("PropertyGuids", (transfer, value) => FGuid.MoveValue(transfer, value.ToObject<FGuid>()));
            PropMovers.Add("BoundPinNames", (transfer, value) => FNameProperty.MoveValue(transfer, value.ToObject<FName>()));
            PropMovers.Add("PinOutputToPinDefaultPersistentId", (transfer, value) => FGuid.MoveValue(transfer, value.ToObject<FGuid>()));
            PropMovers.Add("Locations", (transfer, value) => value.ToObject<FVector2d>().Move(transfer));
            PropMovers.Add("ParameterGuidMapping", (transfer, value) => FGuid.MoveValue(transfer, value.ToObject<FGuid>()));
            PropMovers.Add("InputDescriptions", (transfer, value) => value.ToObject<FText>().Move(transfer));
            PropMovers.Add("OutputDescriptions", (transfer, value) => value.ToObject<FText>().Move(transfer));
            PropMovers.Add("VectorOverrideProxies", (transfer, value) => value.ToObject<FLinearColor>().Move(transfer));
            PropMovers.Add("VectorParamOverrides", (transfer, value) => value.ToObject<FLinearColor>().Move(transfer));
        }
    }
}