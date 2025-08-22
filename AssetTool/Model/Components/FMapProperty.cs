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
            #region keyTypeMovers and valueTypeMovers
            AddTypeKeyMover<FName>("EFaceTextureType");
            AddTypeKeyMover<FName>("EDMMaterialPropertyType");
            AddTypeValueMover<TUInt32>("EVRToolType");
            AddTypeKeyMover<FGuid>(FGuid.TYPE_NAME);
            AddTypeMover<TUInt8, TUInt8>(FBoolProperty.TYPE_NAME);
            AddTypeMover<FName, FName>(FByteProperty.TYPE_NAME);
            AddTypeMover<TDouble, TDouble>(FDoubleProperty.TYPE_NAME);
            AddTypeMover<TFloat, TFloat>(FFloatProperty.TYPE_NAME);
            AddTypeMover<TInt16, TInt16>(FInt16Property.TYPE_NAME);
            AddTypeMover<TUInt16, TUInt16>(FUInt16Property.TYPE_NAME);
            AddTypeMover<TInt64, TInt64>(FInt64Property.TYPE_NAME);
            AddTypeMover<TUInt64, TUInt64>(FUInt64Property.TYPE_NAME);
            AddTypeMover<TInt8, TInt8>(FInt8Property.TYPE_NAME);
            AddTypeMover<TInt32, TInt32>(FIntProperty.TYPE_NAME);
            AddTypeMover<TUInt32, TUInt32>(FUInt32Property.TYPE_NAME);
            AddTypeMover<FName, FName>(FNameProperty.TYPE_NAME);
            AddTypeMover<FString, FString>(FStrProperty.TYPE_NAME);
            AddTypeMover<FText, FText>(FTextProperty.TYPE_NAME);
            AddTypeMover<TUInt32, TUInt32>(FObjectPropertyBase.TYPE_NAME);
            AddTypeMover<TUInt32, TUInt32>(FObjectProperty.TYPE_NAME);
            AddTypeMover<FName, FName>(FEnumProperty.TYPE_NAME);
            AddTypeMover<FSoftObjectPtr, FSoftObjectPtr>(FSoftObjectProperty.TYPE_NAME);
            #endregion

            #region keyNameMovers and valueNameMovers
            AddNameMover<TUInt8, TInt32>("TeamScores");
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
            AddNameValueMover<FVarArgument>("VarArguments");
            AddNameValueMover<FLinearColor>("MaterialVectorParameters_11_57DB292F489BB4FB3E7BE2A66B0245D4");
            AddNameValueMover<FVector>("SocketLocationMap_21_ABF6AA244A5F84728A5E83BE2328C7FA");//Taken from BP_FluidSim_01.uasset
            AddNameValueMover<FVector>("SocketVelocityMap_26_82B0E24B45935A12E1949F918A59A537");//Taken from BP_FluidSim_01.uasset
            #endregion
        }

        #region keyTypeMovers and valueTypeMovers
        static void AddTypeMover<T1, T2>(string name) where T1 : ITransferible, new() where T2 : ITransferible, new()
        {
            keyTypeMovers.Add(name, (transfer, value) => (value.ToObject<T1>(typeof(T1), transfer)).Move(transfer));
            valueTypeMovers.Add(name, (transfer, value) => (value.ToObject<T2>(typeof(T2), transfer)).Move(transfer));
        }

        static void AddTypeKeyMover<T>(string name) where T : ITransferible, new()
        {
            keyTypeMovers.Add(name, (transfer, value) => (value.ToObject<T>(typeof(T), transfer)).Move(transfer));
        }

        static void AddTypeValueMover<T>(string name) where T : ITransferible, new()
        {
            valueTypeMovers.Add(name, (transfer, value) => (value.ToObject<T>(typeof(T), transfer)).Move(transfer));
        }
        #endregion

        #region keyNameMovers and valueNameMovers
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
        #endregion
    }
}