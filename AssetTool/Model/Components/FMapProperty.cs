using System.Diagnostics;

namespace AssetTool
{
    [DebuggerDisplay("{TypeName}<{PropertyTypeName1,PropertyTypeName2}> {NamePrivate.ToString()}")]
    public class FMapProperty : FProperty
    {
        public new const string TYPE_NAME = "MapProperty";
        public override string TypeName => TYPE_NAME;

        public static Dictionary<string, Func<Transfer, object, object>> keyTypeMovers { get; } = new();
        public static Dictionary<string, Func<Transfer, object, object>> keyNameMovers { get; } = new();
        public static Dictionary<string, Func<Transfer, object, object>> valueTypeMovers { get; } = new();
        public static Dictionary<string, Func<Transfer, object, object>> valueNameMovers { get; } = new();

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
                    transfer.Resize(ref KeysToRemove, NumKeysToRemove, true);

                    for (int i = 0; i < NumKeysToRemove; i++)
                    {
                        if (keyTypeMovers.ContainsKey(keyType))
                            KeysToRemove[i] = keyTypeMovers[keyType](transfer, KeysToRemove[i]);
                        else
                            throw new InvalidOperationException($"Invalid Map Key to Remove: {keyType}");
                    }
                }
                transfer.Move(ref NumEntries);

                transfer.Resize(ref KeyProp, NumEntries, true);
                transfer.Resize(ref ValueProp, NumEntries, true);

                for (int i = 0; i < NumEntries; i++)
                {
                    object keyProp = KeyProp[i];
                    object valueProp = ValueProp[i];

                    if (keyNameMovers.ContainsKey(name))
                        keyProp = keyNameMovers[name](transfer, keyProp);
                    else if (keyTypeMovers.ContainsKey(keyType))
                        keyProp = keyTypeMovers[keyType](transfer, keyProp);
                    else
                        keyProp = transfer.MoveTags(keyProp.ToObject<Dictionary<string, object>>(transfer), indent);

                    KeyProp[i] = keyProp;

                    if (valueNameMovers.ContainsKey(name))
                        valueProp = valueNameMovers[name](transfer, valueProp);
                    else if (valueTypeMovers.ContainsKey(valueType))
                        valueProp = valueTypeMovers[valueType](transfer, valueProp);
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
            #region Remove this
            keyTypeMovers.Add("OptimusValueIdentifier", (transfer, value) => transfer.MoveTags(value.ToObject<Dictionary<string, object>>(transfer)));
            keyTypeMovers.Add("RigElementKey", (transfer, value) => transfer.MoveTags(value.ToObject<Dictionary<string, object>>(transfer)));

            valueTypeMovers.Add("OptimusValueIdentifier", (transfer, value) => transfer.MoveTags(value.ToObject<Dictionary<string, object>>(transfer)));
            valueTypeMovers.Add("RigElementKey", (transfer, value) => transfer.MoveTags(value.ToObject<Dictionary<string, object>>(transfer)));
            #endregion

            #region keyTypeMovers
            keyTypeMovers.Add(FGuid.TYPE_NAME, (transfer, value) => FGuid.MoveValue(transfer, value.ToObject<FGuid>(transfer)));
            keyTypeMovers.Add(FBoolProperty.TYPE_NAME, (transfer, value) => FBoolProperty.MoveValue(transfer, value.ToObject<byte>(transfer)));
            keyTypeMovers.Add(FByteProperty.TYPE_NAME, (transfer, value) => FByteProperty.MoveValue(transfer, value.ToObject<FName>(transfer)));
            keyTypeMovers.Add(FDoubleProperty.TYPE_NAME, (transfer, value) => FDoubleProperty.MoveValue(transfer, value.ToObject<double>(transfer)));
            keyTypeMovers.Add(FFloatProperty.TYPE_NAME, (transfer, value) => FFloatProperty.MoveValue(transfer, value.ToObject<float>(transfer)));
            keyTypeMovers.Add(FInt16Property.TYPE_NAME, (transfer, value) => FInt16Property.MoveValue(transfer, value.ToObject<Int16>(transfer)));
            keyTypeMovers.Add(FInt64Property.TYPE_NAME, (transfer, value) => FInt64Property.MoveValue(transfer, value.ToObject<Int64>(transfer)));
            keyTypeMovers.Add(FInt8Property.TYPE_NAME, (transfer, value) => FInt8Property.MoveValue(transfer, value.ToObject<sbyte>(transfer)));
            keyTypeMovers.Add(FIntProperty.TYPE_NAME, (transfer, value) => FIntProperty.MoveValue(transfer, value.ToObject<int>(transfer)));
            keyTypeMovers.Add(FNameProperty.TYPE_NAME, (transfer, value) => FNameProperty.MoveValue(transfer, value.ToObject<FName>(transfer)));
            keyTypeMovers.Add(FStrProperty.TYPE_NAME, (transfer, value) => FStrProperty.MoveValue(transfer, value.ToObject<FString>(transfer)));
            keyTypeMovers.Add(FTextProperty.TYPE_NAME, (transfer, value) => FTextProperty.MoveValue(transfer, value.ToObject<FText>(transfer)));
            keyTypeMovers.Add(FUInt16Property.TYPE_NAME, (transfer, value) => FUInt16Property.MoveValue(transfer, value.ToObject<UInt16>(transfer)));
            keyTypeMovers.Add(FUInt32Property.TYPE_NAME, (transfer, value) => FUInt32Property.MoveValue(transfer, value.ToObject<UInt32>(transfer)));
            keyTypeMovers.Add(FUInt64Property.TYPE_NAME, (transfer, value) => FUInt64Property.MoveValue(transfer, value.ToObject<UInt64>(transfer)));
            keyTypeMovers.Add(FObjectPropertyBase.TYPE_NAME, (transfer, value) => FObjectPropertyBase.MoveValue(transfer, value.ToObject<UInt32>(transfer)));
            keyTypeMovers.Add(FObjectProperty.TYPE_NAME, (transfer, value) => FObjectProperty.MoveValue(transfer, value.ToObject<UInt32>(transfer)));
            keyTypeMovers.Add(FEnumProperty.TYPE_NAME, (transfer, value) => FEnumProperty.MoveValue(transfer, value.ToObject<FName>(transfer)));
            keyTypeMovers.Add(FSoftObjectProperty.TYPE_NAME, (transfer, value) => value.ToObject<FSoftObjectProperty>(transfer).ConvertFromType(transfer));
            keyTypeMovers.Add("EDMMaterialPropertyType", (transfer, value) => value.ToObject<FName>(transfer).Move(transfer));
            #endregion

            #region valueTypeMovers
            valueTypeMovers.Add(FBoolProperty.TYPE_NAME, (transfer, value) => FBoolProperty.MoveValue(transfer, value.ToObject<byte>(transfer)));
            valueTypeMovers.Add(FByteProperty.TYPE_NAME, (transfer, value) => FByteProperty.MoveValue(transfer, value.ToObject<FName>(transfer)));
            valueTypeMovers.Add(FDoubleProperty.TYPE_NAME, (transfer, value) => FDoubleProperty.MoveValue(transfer, value.ToObject<double>(transfer)));
            valueTypeMovers.Add(FFloatProperty.TYPE_NAME, (transfer, value) => FFloatProperty.MoveValue(transfer, value.ToObject<float>(transfer)));
            valueTypeMovers.Add(FInt16Property.TYPE_NAME, (transfer, value) => FInt16Property.MoveValue(transfer, value.ToObject<Int16>(transfer)));
            valueTypeMovers.Add(FInt64Property.TYPE_NAME, (transfer, value) => FInt64Property.MoveValue(transfer, value.ToObject<Int64>(transfer)));
            valueTypeMovers.Add(FInt8Property.TYPE_NAME, (transfer, value) => FInt8Property.MoveValue(transfer, value.ToObject<sbyte>(transfer)));
            valueTypeMovers.Add(FIntProperty.TYPE_NAME, (transfer, value) => FIntProperty.MoveValue(transfer, value.ToObject<int>(transfer)));
            valueTypeMovers.Add(FNameProperty.TYPE_NAME, (transfer, value) => FNameProperty.MoveValue(transfer, value.ToObject<FName>(transfer)));
            valueTypeMovers.Add(FStrProperty.TYPE_NAME, (transfer, value) => FStrProperty.MoveValue(transfer, value.ToObject<FString>(transfer)));
            valueTypeMovers.Add(FTextProperty.TYPE_NAME, (transfer, value) => FTextProperty.MoveValue(transfer, value.ToObject<FText>(transfer)));
            valueTypeMovers.Add(FUInt16Property.TYPE_NAME, (transfer, value) => FUInt16Property.MoveValue(transfer, value.ToObject<UInt16>(transfer)));
            valueTypeMovers.Add(FUInt32Property.TYPE_NAME, (transfer, value) => FUInt32Property.MoveValue(transfer, value.ToObject<UInt32>(transfer)));
            valueTypeMovers.Add(FUInt64Property.TYPE_NAME, (transfer, value) => FUInt64Property.MoveValue(transfer, value.ToObject<UInt64>(transfer)));
            valueTypeMovers.Add(FObjectPropertyBase.TYPE_NAME, (transfer, value) => FObjectPropertyBase.MoveValue(transfer, value.ToObject<UInt32>(transfer)));
            valueTypeMovers.Add(FObjectProperty.TYPE_NAME, (transfer, value) => FObjectProperty.MoveValue(transfer, value.ToObject<UInt32>(transfer)));
            valueTypeMovers.Add(FEnumProperty.TYPE_NAME, (transfer, value) => FEnumProperty.MoveValue(transfer, value.ToObject<FName>(transfer)));
            valueTypeMovers.Add(FSoftObjectProperty.TYPE_NAME, (transfer, value) => value.ToObject<FSoftObjectProperty>(transfer).ConvertFromType(transfer));
            valueTypeMovers.Add("EVRToolType", (transfer, value) => value.ToObject<TUInt32>(transfer).Move(transfer));
            #endregion

            #region keyNameMovers and valueNameMovers
            AddNameMover<FAnimationAttributeIdentifier, FAttributeCurve>("AttributeCurves");
            AddNameMover<FNiagaraVariable, FNiagaraVariable>("UserParameterRedirects");
            AddNameMover<FNiagaraVariable, TUInt32>("VariableToScriptVariable");
            AddNameMover<FGuid, FName>("BoundPinNames");
            AddNameMover<FGuid, FGuid>("PinOutputToPinDefaultPersistentId");
            AddNameMover<FGuid, FVector2d>("Locations");
            AddNameKeyMover<FGuid>("LayersData");
            AddNameMover<FNiagaraVariable, FGuid>("ParameterGuidMapping");
            AddNameMover<FNiagaraVariableBase, FText>("InputDescriptions");
            AddNameMover<FNiagaraVariableBase, FText>("OutputDescriptions");
            AddNameMover<FStructPropertyItem, TUInt32>("Dependencies");
            AddNameKeyMover<FNiagaraVariableBase>("TemplateParameterOverrides");
            AddNameKeyMover<FStructPropertyItem>("Constraints");
            AddNameKeyMover<FGuid>("BindingIdToReferences");
            AddNameMover<FSoftObjectPath, TUInt32>("AppliedModifiers");
            AddNameMover<FGuid, TUInt32>("MessageKeyToMessageMap");
            AddNameMover<FGuid, TUInt32>("MemberMetadata");
            AddNameKeyMover<FName>("Locks");
            AddNameMover<TUInt8, FObjectPtr>("TeamsToCreate");
            AddNameKeyMover<FNiagaraVariableBase>("InstanceParameterOverrides");
            AddNameMover<FName, FGuid>("SpecializedReferenceToGuid");
            AddNameMover<FGuid, FName>("GuidToSpecializedReference");
            AddNameValueMover<FGuid>("PropertyGuids");
            AddNameValueMover<FLinearColor>("VectorOverrideProxies");
            AddNameValueMover<FLinearColor>("VectorParamOverrides");
            AddNameValueMover<FLinearColor>("Custom Vector Params");
            AddNameValueMover<FGuid>("NamedSlotsWithID");
            AddNameValueMover<FVector3f>("OriginalPositionData");
            AddNameValueMover<FLinearColor>("VectorParameterValues");
            AddNameValueMover<FQuat>("BoneRotationOffsets");
            AddNameValueMover<FSoftObjectPath>("UserDefinedStructGuidToPathName");
            AddNameValueMover<FSoftObjectPath>("UserDefinedEnumToPathName");
            AddNameValueMover<FGuid>("GridGuids");
            AddNameValueMover<FTypedParameter>("PitchShifterOptions");
            AddNameValueMover<TUInt8>("FilterStates");//Correct type is ECurveEditorTreeFilterState
            AddNameValueMover<FLinearColor>("ColorParameters");
            AddNameValueMover<FText>("FailureTagToUserFacingMessages");
            AddNameValueMover<FObjectPtr>("FailureTagToAnimMontage");
            AddNameValueMover<FLinearColor>("TeamColors");
            AddNameValueMover<FGuid>("WidgetVariableNameToGuidMap");
            AddNameValueMover<FObjectPtr>("PropertySlotMap");
            #endregion
        }

        static void AddNameMover<T1, T2>(string name) where T1 : ITransferible, new() where T2 : ITransferible, new()
        {
            keyNameMovers.Add(name, (transfer, value) => (value.ToObject<T1>(typeof(T1), transfer)).Move(transfer));
            valueNameMovers.Add(name, (transfer, value) => (value.ToObject<T2>(typeof(T2), transfer)).Move(transfer));
        }

        static void AddNameKeyMover<T>(string name) where T : ITransferible, new()
        {
            keyNameMovers.Add(name, (transfer, value) => (value.ToObject<T>(typeof(T), transfer)).Move(transfer));
        }

        static void AddNameValueMover<T>(string name) where T : ITransferible, new()
        {
            valueNameMovers.Add(name, (transfer, value) => (value.ToObject<T>(typeof(T), transfer)).Move(transfer));
        }
    }
}