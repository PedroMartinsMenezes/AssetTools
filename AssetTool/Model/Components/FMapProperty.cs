using System.Diagnostics;

namespace AssetTool
{
    [DebuggerDisplay("{TypeName}<{PropertyTypeName1,PropertyTypeName2}> {NamePrivate.ToString()}")]
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
        public List<object> KeysToRemove;
        public List<object> KeyProp = [];
        public List<object> ValueProp = [];
        #endregion

        #region Serialize
        [Location("void FMapProperty::Serialize( FArchive& Ar )")]
        public override FField Move(Transfer transfer)
        {
            base.Move(transfer);
            FField.SerializeSingleField(transfer, ref PropertyTypeName1, ref SingleField1);
            FField.SerializeSingleField(transfer, ref PropertyTypeName2, ref SingleField2);
            return this;
        }
        #endregion

        #region SerializeItem
        [Location("void FMapProperty::SerializeItem(FStructuredArchive::FSlot Slot, void* Value, const void* Defaults) const")]
        public FMapProperty MoveValue(Transfer transfer, string name, string valueType, string keyType, int indent)
        {
            try
            {
                transfer.Move(ref NumKeysToRemove);
                if (NumKeysToRemove > 0)
                {
                    KeysToRemove = KeysToRemove.Resize(transfer, NumKeysToRemove, true);
                    for (int i = 0; i < NumKeysToRemove; i++)
                    {
                        if (ValueMovers.ContainsKey(keyType))
                            KeysToRemove[i] = ValueMovers[keyType](transfer, KeysToRemove[i]);
                        else
                            throw new InvalidOperationException($"Invalid Map Key to Remove: {keyType}");
                    }
                }

                transfer.Move(ref NumEntries);
                KeyProp.Resize(transfer, NumEntries, true);
                ValueProp.Resize(transfer, NumEntries, true);

                for (int i = 0; i < NumEntries; i++)
                {
                    object keyProp = KeyProp[i];
                    object valueProp = ValueProp[i];

                    if (ValueMovers.ContainsKey(keyType))
                        keyProp = ValueMovers[keyType](transfer, keyProp);
                    else if (KeyMovers.ContainsKey(name))
                        keyProp = KeyMovers[name](transfer, keyProp);
                    else
                        keyProp = transfer.MoveTags(keyProp.ToObject<Dictionary<string, object>>(transfer), indent);

                    KeyProp[i] = keyProp;

                    if (PropMovers.ContainsKey(name))
                        valueProp = PropMovers[name](transfer, valueProp);
                    else if (ValueMovers.ContainsKey(valueType))
                        valueProp = ValueMovers[valueType](transfer, valueProp);
                    else
                        valueProp = transfer.MoveTags(valueProp.ToObject<Dictionary<string, object>>(transfer), indent);

                    valueProp ??= transfer.MoveTags(ValueProp[i].ToObject<Dictionary<string, object>>(transfer), indent);

                    ValueProp[i] = valueProp;
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
            ValueMovers.Add(FGuid.TYPE_NAME, (transfer, value) => FGuid.MoveValue(transfer, value.ToObject<FGuid>(transfer)));
            ValueMovers.Add(FBoolProperty.TYPE_NAME, (transfer, value) => FBoolProperty.MoveValue(transfer, value.ToObject<byte>(transfer)));
            ValueMovers.Add(FByteProperty.TYPE_NAME, (transfer, value) => FByteProperty.MoveValue(transfer, value.ToObject<FName>(transfer)));
            ValueMovers.Add(FDoubleProperty.TYPE_NAME, (transfer, value) => FDoubleProperty.MoveValue(transfer, value.ToObject<double>(transfer)));
            ValueMovers.Add(FFloatProperty.TYPE_NAME, (transfer, value) => FFloatProperty.MoveValue(transfer, value.ToObject<float>(transfer)));
            ValueMovers.Add(FInt16Property.TYPE_NAME, (transfer, value) => FInt16Property.MoveValue(transfer, value.ToObject<Int16>(transfer)));
            ValueMovers.Add(FInt64Property.TYPE_NAME, (transfer, value) => FInt64Property.MoveValue(transfer, value.ToObject<Int64>(transfer)));
            ValueMovers.Add(FInt8Property.TYPE_NAME, (transfer, value) => FInt8Property.MoveValue(transfer, value.ToObject<sbyte>(transfer)));
            ValueMovers.Add(FIntProperty.TYPE_NAME, (transfer, value) => FIntProperty.MoveValue(transfer, value.ToObject<int>(transfer)));
            ValueMovers.Add(FNameProperty.TYPE_NAME, (transfer, value) => FNameProperty.MoveValue(transfer, value.ToObject<FName>(transfer)));
            ValueMovers.Add(FStrProperty.TYPE_NAME, (transfer, value) => FStrProperty.MoveValue(transfer, value.ToObject<FString>(transfer)));
            ValueMovers.Add(FTextProperty.TYPE_NAME, (transfer, value) => FTextProperty.MoveValue(transfer, value.ToObject<FText>(transfer)));
            ValueMovers.Add(FUInt16Property.TYPE_NAME, (transfer, value) => FUInt16Property.MoveValue(transfer, value.ToObject<UInt16>(transfer)));
            ValueMovers.Add(FUInt32Property.TYPE_NAME, (transfer, value) => FUInt32Property.MoveValue(transfer, value.ToObject<UInt32>(transfer)));
            ValueMovers.Add(FUInt64Property.TYPE_NAME, (transfer, value) => FUInt64Property.MoveValue(transfer, value.ToObject<UInt64>(transfer)));
            ValueMovers.Add(FObjectPropertyBase.TYPE_NAME, (transfer, value) => FObjectPropertyBase.MoveValue(transfer, value.ToObject<UInt32>(transfer)));
            ValueMovers.Add(FObjectProperty.TYPE_NAME, (transfer, value) => FObjectProperty.MoveValue(transfer, value.ToObject<UInt32>(transfer)));
            ValueMovers.Add(FEnumProperty.TYPE_NAME, (transfer, value) => FEnumProperty.MoveValue(transfer, value.ToObject<FName>(transfer)));
            ValueMovers.Add("OptimusValueIdentifier", (transfer, value) => transfer.MoveTags(value.ToObject<Dictionary<string, object>>(transfer)));
            ValueMovers.Add("RigElementKey", (transfer, value) => transfer.MoveTags(value.ToObject<Dictionary<string, object>>(transfer)));

            //Keys (Mistery)            
            KeyMovers.Add("AttributeCurves", (transfer, value) => value.ToObject<FAnimationAttributeIdentifier>(transfer).Move(transfer));
            KeyMovers.Add("UserParameterRedirects", (transfer, value) => value.ToObject<FNiagaraVariable>(transfer).Move(transfer));
            KeyMovers.Add("VariableToScriptVariable", (transfer, value) => value.ToObject<FNiagaraVariable>(transfer)?.Move(transfer));
            KeyMovers.Add("BoundPinNames", (transfer, value) => FGuid.MoveValue(transfer, value.ToObject<FGuid>(transfer)));
            KeyMovers.Add("PinOutputToPinDefaultPersistentId", (transfer, value) => FGuid.MoveValue(transfer, value.ToObject<FGuid>(transfer)));
            KeyMovers.Add("Locations", (transfer, value) => FGuid.MoveValue(transfer, value.ToObject<FGuid>(transfer)));
            KeyMovers.Add("LayersData", (transfer, value) => FGuid.MoveValue(transfer, value.ToObject<FGuid>(transfer)));
            KeyMovers.Add("ParameterGuidMapping", (transfer, value) => value.ToObject<FNiagaraVariable>(transfer).Move(transfer));
            KeyMovers.Add("InputDescriptions", (transfer, value) => value.ToObject<FNiagaraVariableBase>(transfer).Move(transfer));
            KeyMovers.Add("OutputDescriptions", (transfer, value) => value.ToObject<FNiagaraVariableBase>(transfer).Move(transfer));
            KeyMovers.Add("Dependencies", (transfer, value) => transfer.MoveTags(value.ToObject<Dictionary<string, object>>(transfer)));
            KeyMovers.Add("TemplateParameterOverrides", (transfer, value) => value.ToObject<FNiagaraVariableBase>(transfer).Move(transfer));
            KeyMovers.Add("Constraints", (transfer, value) => transfer.MoveTags(value.ToObject<Dictionary<string, object>>(transfer)));
            KeyMovers.Add("BindingIdToReferences", (transfer, value) => FGuid.MoveValue(transfer, value.ToObject<FGuid>(transfer)));
            KeyMovers.Add("AppliedModifiers", (transfer, value) => value.ToObject<FSoftObjectPath>(transfer).Move(transfer));

            //Props (Mistery)
            PropMovers.Add("AttributeCurves", (transfer, value) => value.ToObject<FAttributeCurve>(transfer).Move(transfer));
            PropMovers.Add("UserParameterRedirects", (transfer, value) => value.ToObject<FNiagaraVariable>(transfer).Move(transfer));
            PropMovers.Add("VariableToScriptVariable", (transfer, value) => FUInt32Property.MoveValue(transfer, value.ToObject<UInt32>(transfer)));
            PropMovers.Add("PropertyGuids", (transfer, value) => FGuid.MoveValue(transfer, value.ToObject<FGuid>(transfer)));
            PropMovers.Add("BoundPinNames", (transfer, value) => FNameProperty.MoveValue(transfer, value.ToObject<FName>(transfer)));
            PropMovers.Add("PinOutputToPinDefaultPersistentId", (transfer, value) => FGuid.MoveValue(transfer, value.ToObject<FGuid>(transfer)));
            PropMovers.Add("Locations", (transfer, value) => value.ToObject<FVector2d>(transfer).Move(transfer));
            PropMovers.Add("ParameterGuidMapping", (transfer, value) => FGuid.MoveValue(transfer, value.ToObject<FGuid>(transfer)));
            PropMovers.Add("InputDescriptions", (transfer, value) => value.ToObject<FText>(transfer).Move(transfer));
            PropMovers.Add("OutputDescriptions", (transfer, value) => value.ToObject<FText>(transfer).Move(transfer));
            PropMovers.Add("VectorOverrideProxies", (transfer, value) => value.ToObject<FLinearColor>(transfer).Move(transfer));
            PropMovers.Add("VectorParamOverrides", (transfer, value) => value.ToObject<FLinearColor>(transfer).Move(transfer));
            PropMovers.Add("Custom Vector Params", (transfer, value) => value.ToObject<FLinearColor>(transfer).Move(transfer));
            PropMovers.Add("NamedSlotsWithID", (transfer, value) => FGuid.MoveValue(transfer, value.ToObject<FGuid>(transfer)));
            PropMovers.Add("OriginalPositionData", (transfer, value) => value.ToObject<FVector3f>(transfer).Move(transfer));
            PropMovers.Add("VectorParameterValues", (transfer, value) => value.ToObject<FLinearColor>(transfer).Move(transfer));
            PropMovers.Add("BoneRotationOffsets", (transfer, value) => value.ToObject<FQuat>(transfer).Move(transfer));
            PropMovers.Add("UserDefinedStructGuidToPathName", (transfer, value) => value.ToObject<FSoftObjectPath>(transfer).Move(transfer));
            PropMovers.Add("Dependencies", (transfer, value) => FUInt32Property.MoveValue(transfer, value.ToObject<UInt32>(transfer)));
            PropMovers.Add("UserDefinedEnumToPathName", (transfer, value) => value.ToObject<FSoftObjectPath>(transfer).Move(transfer));
            PropMovers.Add("AppliedModifiers", (transfer, value) => FUInt32Property.MoveValue(transfer, value.ToObject<UInt32>(transfer)));
        }
    }
}