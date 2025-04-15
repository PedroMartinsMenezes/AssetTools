using System.Diagnostics;

namespace AssetTool
{
    [DebuggerDisplay("{TypeName}<{PropertyTypeName}> {NamePrivate.ToString()}")]
    public class FSetProperty : FProperty
    {
        public new const string TYPE_NAME = "SetProperty";
        public override string TypeName => TYPE_NAME;

        #region Serialize
        public FName PropertyTypeName;
        public FField Field;
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
            FField.SerializeSingleField(transfer, ref PropertyTypeName, ref Field);
            return this;
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
                else if (TransfersForSetProperty.ContainsKey(name))
                    Values[i] = TransfersForSetProperty[name](transfer, Values[i]);
                else if (keyType == FStructProperty.TYPE_NAME)
                    Values[i] = transfer.MoveTags(Values[i].ToObject<Dictionary<string, object>>(transfer), indent);
                else
                    throw new InvalidOperationException($"Invalid Type : {keyType}");
            }
        }
        #endregion

        static FSetProperty()
        {
            ///Transfers.Add(FGuid.TYPE_NAME, (transfer, value) => FGuid.MoveValue(transfer, value.ToObject<FGuid>()));

            #region OK
            Transfers.Add(FBoolProperty.TYPE_NAME, (transfer, value) => FBoolProperty.MoveValue(transfer, value.ToObject<byte>(transfer)));
            Transfers.Add(FByteProperty.TYPE_NAME, (transfer, value) => FByteProperty.MoveValue(transfer, value.ToObject<FName>(transfer)));
            Transfers.Add(FDoubleProperty.TYPE_NAME, (transfer, value) => FDoubleProperty.MoveValue(transfer, value.ToObject<double>(transfer)));
            Transfers.Add(FFloatProperty.TYPE_NAME, (transfer, value) => FFloatProperty.MoveValue(transfer, value.ToObject<float>(transfer)));
            Transfers.Add(FInt16Property.TYPE_NAME, (transfer, value) => FInt16Property.MoveValue(transfer, value.ToObject<Int16>(transfer)));
            Transfers.Add(FInt64Property.TYPE_NAME, (transfer, value) => FInt64Property.MoveValue(transfer, value.ToObject<Int64>(transfer)));
            Transfers.Add(FInt8Property.TYPE_NAME, (transfer, value) => FInt8Property.MoveValue(transfer, value.ToObject<sbyte>(transfer)));
            Transfers.Add(FIntProperty.TYPE_NAME, (transfer, value) => FIntProperty.MoveValue(transfer, value.ToObject<int>(transfer)));
            Transfers.Add(FNameProperty.TYPE_NAME, (transfer, value) => FNameProperty.MoveValue(transfer, value.ToObject<FName>(transfer)));
            Transfers.Add(FStrProperty.TYPE_NAME, (transfer, value) => FStrProperty.MoveValue(transfer, value.ToObject<FString>(transfer)));
            Transfers.Add(FTextProperty.TYPE_NAME, (transfer, value) => FTextProperty.MoveValue(transfer, value.ToObject<FText>(transfer)));
            Transfers.Add(FUInt16Property.TYPE_NAME, (transfer, value) => FUInt16Property.MoveValue(transfer, value.ToObject<UInt16>(transfer)));
            Transfers.Add(FUInt32Property.TYPE_NAME, (transfer, value) => FUInt32Property.MoveValue(transfer, value.ToObject<UInt32>(transfer)));
            Transfers.Add(FUInt64Property.TYPE_NAME, (transfer, value) => FUInt64Property.MoveValue(transfer, value.ToObject<UInt64>(transfer)));
            Transfers.Add(FObjectPropertyBase.TYPE_NAME, (transfer, value) => FObjectPropertyBase.MoveValue(transfer, value.ToObject<UInt32>(transfer)));
            Transfers.Add(FObjectProperty.TYPE_NAME, (transfer, value) => FObjectProperty.MoveValue(transfer, value.ToObject<UInt32>(transfer)));
            Transfers.Add(FEnumProperty.TYPE_NAME, (transfer, value) => FEnumProperty.MoveValue(transfer, value.ToObject<FName>(transfer)));
            Transfers.Add(FClassProperty.TYPE_NAME, (transfer, value) => FClassProperty.MoveValue(transfer, value.ToObject<UInt32>(transfer)));
            #endregion

            #region NOK
            ///Transfers.Add(FStructProperty.TYPE_NAME, (transfer, value) => FStructProperty.SerializeItem(transfer, value.ToObject<UInt32>()));
            #endregion

            #region Values found on Folder: Plugins
            TransfersForSetProperty.Add("PropertiesIDsOverridden", (transfer, value) => FGuid.MoveValue(transfer, value.ToObject<FGuid>(transfer)));
            #endregion

            #region Values found on Folder: Plugins - Failed
            ///TransfersForName.Add("AllowedClassForConversionFunctions", (transfer, value) => FSoftClassPath.MoveValue(transfer, value.ToObject<FSoftClassPath>()));
            ///TransfersForName.Add("AllowedContextCreationType", (transfer, value) => EMVVMBlueprintViewModelContextCreationType.MoveValue(transfer, value.ToObject<EMVVMBlueprintViewModelContextCreationType>()));
            ///TransfersForName.Add("AllowedExecutionMode", (transfer, value) => EMVVMExecutionMode.MoveValue(transfer, value.ToObject<EMVVMExecutionMode>()));
            ///TransfersForName.Add("ExposedEntities", (transfer, value) => FRCEntityWrapper.MoveValue(transfer, value.ToObject<FRCEntityWrapper>()));
            ///TransfersForName.Add("Interfaces", (transfer, value) => FMetasoundFrontendVersion.MoveValue(transfer, value.ToObject<FMetasoundFrontendVersion>()));
            ///TransfersForName.Add("Mappings", (transfer, value) => FPlayerKeyMapping.MoveValue(transfer, value.ToObject<FPlayerKeyMapping>()));
            ///TransfersForName.Add("Mappings", (transfer, value) => FRemoteControlProtocolMapping.MoveValue(transfer, value.ToObject<FRemoteControlProtocolMapping>()));
            ///TransfersForName.Add("ProtocolBindings", (transfer, value) => FRemoteControlProtocolBinding.MoveValue(transfer, value.ToObject<FRemoteControlProtocolBinding>()));
            ///TransfersForName.Add("SerializedDataPerFilter", (transfer, value) => FObjectMixerSerializationDataPerFilter.MoveValue(transfer, value.ToObject<FObjectMixerSerializationDataPerFilter>()));
            ///TransfersForName.Add("Vertices", (transfer, value) => FGraphVertexHandle.MoveValue(transfer, value.ToObject<FGraphVertexHandle>()));
            ///TransfersForName.Add("AllowedTypes", (transfer, value) => TEnumAsByte<EBlueprintPropertyType::Type>.MoveValue(transfer, value.ToObject<TEnumAsByte<EBlueprintPropertyType::Type>>()));
            ///TransfersForName.Add("Attributes", (transfer, value) => FDMXAttribute.MoveValue(transfer, value.ToObject<FDMXAttribute>()));
            ///TransfersForName.Add("Set", (transfer, value) => FExternalReferenceDummy.MoveValue(transfer, value.ToObject<FExternalReferenceDummy>()));
            ///TransfersForName.Add("SkippedClasses", (transfer, value) => FSoftClassPath.MoveValue(transfer, value.ToObject<FSoftClassPath>()));
            ///TransfersForName.Add("StructInnerSet", (transfer, value) => FRemoteControlTestStructInner.MoveValue(transfer, value.ToObject<FRemoteControlTestStructInner>()));
            ///TransfersForName.Add("Tags", (transfer, value) => FStrProperty.MoveValue(transfer, value.ToObject<FString>()));
            #endregion

            #region Values found on Folder: Plugins - Ignored
            ///TransfersForName.Add("ActionContainers", (transfer, value) => FUInt32Property.MoveValue(transfer, value.ToObject<UInt32>()));
            ///TransfersForName.Add("Actions", (transfer, value) => FUInt32Property.MoveValue(transfer, value.ToObject<UInt32>()));
            ///TransfersForName.Add("AdditionalConsoleCommands", (transfer, value) => FStrProperty.MoveValue(transfer, value.ToObject<FString>()));
            ///TransfersForName.Add("AdditionalConsoleVariables", (transfer, value) => FStrProperty.MoveValue(transfer, value.ToObject<FString>()));
            ///TransfersForName.Add("AdditionalTags", (transfer, value) => FStrProperty.MoveValue(transfer, value.ToObject<FString>()));
            ///TransfersForName.Add("AddPending", (transfer, value) => FIntProperty.MoveValue(transfer, value.ToObject<int>()));
            ///TransfersForName.Add("AdvancedFieldNames", (transfer, value) => FNameProperty.MoveValue(transfer, value.ToObject<FName>()));
            ///TransfersForName.Add("AffectedActors", (transfer, value) => FUInt32Property.MoveValue(transfer, value.ToObject<UInt32>()));
            ///TransfersForName.Add("AllComponents", (transfer, value) => FUInt32Property.MoveValue(transfer, value.ToObject<UInt32>()));
            ///TransfersForName.Add("AllDerivedTextures", (transfer, value) => FUInt32Property.MoveValue(transfer, value.ToObject<UInt32>()));
            ///TransfersForName.Add("AllowedNames", (transfer, value) => FStrProperty.MoveValue(transfer, value.ToObject<FString>()));
            ///TransfersForName.Add("AllowedTags", (transfer, value) => FNameProperty.MoveValue(transfer, value.ToObject<FName>()));
            ///TransfersForName.Add("AuthorizedClientKeys", (transfer, value) => FStrProperty.MoveValue(transfer, value.ToObject<FString>()));
            ///TransfersForName.Add("Behaviours", (transfer, value) => FUInt32Property.MoveValue(transfer, value.ToObject<UInt32>()));
            ///TransfersForName.Add("CachedLayerNames", (transfer, value) => FNameProperty.MoveValue(transfer, value.ToObject<FName>()));
            ///TransfersForName.Add("ChangedConsoleVariableSkipList", (transfer, value) => FStrProperty.MoveValue(transfer, value.ToObject<FString>()));
            ///TransfersForName.Add("ChaosBreakingMaterialSet", (transfer, value) => FUInt32Property.MoveValue(transfer, value.ToObject<UInt32>()));
            ///TransfersForName.Add("ChaosSolverActorSet", (transfer, value) => FUInt32Property.MoveValue(transfer, value.ToObject<UInt32>()));
            ///TransfersForName.Add("CommandLineArguments", (transfer, value) => FStrProperty.MoveValue(transfer, value.ToObject<FString>()));
            ///TransfersForName.Add("CustomizableObjectGuidsInCompilation", (transfer, value) => FGuid.MoveValue(transfer, value.ToObject<FGuid>()));
            ///TransfersForName.Add("DisallowedFieldNames", (transfer, value) => FNameProperty.MoveValue(transfer, value.ToObject<FName>()));
            ///TransfersForName.Add("EnabledPresetCollections", (transfer, value) => FIntProperty.MoveValue(transfer, value.ToObject<int>()));
            ///TransfersForName.Add("ExpandedPins", (transfer, value) => FNameProperty.MoveValue(transfer, value.ToObject<FName>()));
            ///TransfersForName.Add("ExposedTypes", (transfer, value) => FUInt32Property.MoveValue(transfer, value.ToObject<UInt32>()));
            ///TransfersForName.Add("FilterOnTags", (transfer, value) => FStrProperty.MoveValue(transfer, value.ToObject<FString>()));
            ///TransfersForName.Add("FixtureCategories", (transfer, value) => FNameProperty.MoveValue(transfer, value.ToObject<FName>()));
            ///TransfersForName.Add("GeneratedActors", (transfer, value) => FUInt32Property.MoveValue(transfer, value.ToObject<UInt32>()));
            ///TransfersForName.Add("GeneratedActors_DEPRECATED", (transfer, value) => FUInt32Property.MoveValue(transfer, value.ToObject<UInt32>()));
            ///TransfersForName.Add("HandledBindingGuids", (transfer, value) => FGuid.MoveValue(transfer, value.ToObject<FGuid>()));
            ///TransfersForName.Add("HiddenProtocolTypeNames", (transfer, value) => FNameProperty.MoveValue(transfer, value.ToObject<FName>()));
            ///TransfersForName.Add("Indices", (transfer, value) => FIntProperty.MoveValue(transfer, value.ToObject<int>()));
            ///TransfersForName.Add("InputPinLabels_DEPRECATED", (transfer, value) => FNameProperty.MoveValue(transfer, value.ToObject<FName>()));
            ///TransfersForName.Add("InputsInheritingDefault", (transfer, value) => FNameProperty.MoveValue(transfer, value.ToObject<FName>()));
            ///TransfersForName.Add("IntSet", (transfer, value) => FIntProperty.MoveValue(transfer, value.ToObject<int>()));
            ///TransfersForName.Add("LastInjectedActions", (transfer, value) => FUInt32Property.MoveValue(transfer, value.ToObject<UInt32>()));
            ///TransfersForName.Add("Layers", (transfer, value) => FNameProperty.MoveValue(transfer, value.ToObject<FName>()));
            ///TransfersForName.Add("LevelsToIgnore", (transfer, value) => FStrProperty.MoveValue(transfer, value.ToObject<FString>()));
            ///TransfersForName.Add("LoadedPaletteCollectionSet", (transfer, value) => FUInt32Property.MoveValue(transfer, value.ToObject<UInt32>()));
            ///TransfersForName.Add("LoadedPresetCollections", (transfer, value) => FIntProperty.MoveValue(transfer, value.ToObject<int>()));
            ///TransfersForName.Add("MeshesAskedToFixRootHeightFor", (transfer, value) => FUInt32Property.MoveValue(transfer, value.ToObject<UInt32>()));
            ///TransfersForName.Add("MetaDataTagsForAssetRegistry", (transfer, value) => FNameProperty.MoveValue(transfer, value.ToObject<FName>()));
            ///TransfersForName.Add("NetReplicationPending", (transfer, value) => FIntProperty.MoveValue(transfer, value.ToObject<int>()));
            ///TransfersForName.Add("ObjectSet", (transfer, value) => FUInt32Property.MoveValue(transfer, value.ToObject<UInt32>()));
            ///TransfersForName.Add("OtherParents", (transfer, value) => FUInt32Property.MoveValue(transfer, value.ToObject<UInt32>()));
            ///TransfersForName.Add("OutputNodesDataSentTo", (transfer, value) => FUInt32Property.MoveValue(transfer, value.ToObject<UInt32>()));
            ///TransfersForName.Add("OutputPinLabels_DEPRECATED", (transfer, value) => FNameProperty.MoveValue(transfer, value.ToObject<FName>()));
            ///TransfersForName.Add("OwnedAssets", (transfer, value) => FUInt32Property.MoveValue(transfer, value.ToObject<UInt32>()));
            ///TransfersForName.Add("ParsedActorTagsList", (transfer, value) => FNameProperty.MoveValue(transfer, value.ToObject<FName>()));
            ///TransfersForName.Add("PinLabels_DEPRECATED", (transfer, value) => FNameProperty.MoveValue(transfer, value.ToObject<FName>()));
            ///TransfersForName.Add("PlayersWhoseViewTargetsWereSet", (transfer, value) => FUInt32Property.MoveValue(transfer, value.ToObject<UInt32>()));
            ///TransfersForName.Add("PreloadSequences", (transfer, value) => FUInt32Property.MoveValue(transfer, value.ToObject<UInt32>()));
            ///TransfersForName.Add("PrimsToAnimate", (transfer, value) => FStrProperty.MoveValue(transfer, value.ToObject<FString>()));
            ///TransfersForName.Add("RecursiveClassesExclusionSet", (transfer, value) => FNameProperty.MoveValue(transfer, value.ToObject<FName>()));
            ///TransfersForName.Add("ReferenceAssetClassCache", (transfer, value) => FIntProperty.MoveValue(transfer, value.ToObject<int>()));
            ///TransfersForName.Add("ReferencedAssetClassKeys", (transfer, value) => FStrProperty.MoveValue(transfer, value.ToObject<FString>()));
            ///TransfersForName.Add("ReferencedAssetClassObjects", (transfer, value) => FUInt32Property.MoveValue(transfer, value.ToObject<UInt32>()));
            ///TransfersForName.Add("RegisteredMappingContexts", (transfer, value) => FUInt32Property.MoveValue(transfer, value.ToObject<UInt32>()));
            ///TransfersForName.Add("RoleSources", (transfer, value) => FNameProperty.MoveValue(transfer, value.ToObject<FName>()));
            ///TransfersForName.Add("SceneActorCompContainer", (transfer, value) => FUInt32Property.MoveValue(transfer, value.ToObject<UInt32>()));
            ///TransfersForName.Add("SelectedPoints", (transfer, value) => FIntProperty.MoveValue(transfer, value.ToObject<int>()));
            ///TransfersForName.Add("SelectedRenderGridJobIds", (transfer, value) => FGuid.MoveValue(transfer, value.ToObject<FGuid>()));
            ///TransfersForName.Add("SessionIds", (transfer, value) => FGuid.MoveValue(transfer, value.ToObject<FGuid>()));
            ///TransfersForName.Add("SetProp", (transfer, value) => FStrProperty.MoveValue(transfer, value.ToObject<FString>()));
            ///TransfersForName.Add("SetProperty", (transfer, value) => FIntProperty.MoveValue(transfer, value.ToObject<int>()));
            ///TransfersForName.Add("SharedActionContainers", (transfer, value) => FUInt32Property.MoveValue(transfer, value.ToObject<UInt32>()));
            ///TransfersForName.Add("SoftObjectPtrSet", (transfer, value) => FUInt32Property.MoveValue(transfer, value.ToObject<UInt32>()));
            ///TransfersForName.Add("SoftPathSet", (transfer, value) => FIntProperty.MoveValue(transfer, value.ToObject<int>()));
            ///TransfersForName.Add("SoundscapePaletteCollection", (transfer, value) => FIntProperty.MoveValue(transfer, value.ToObject<int>()));
            ///TransfersForName.Add("StringSet", (transfer, value) => FStrProperty.MoveValue(transfer, value.ToObject<FString>()));
            ///TransfersForName.Add("Tags", (transfer, value) => FNameProperty.MoveValue(transfer, value.ToObject<FName>()));
            ///TransfersForName.Add("TagsAppliedOnOutput", (transfer, value) => FStrProperty.MoveValue(transfer, value.ToObject<FString>()));
            ///TransfersForName.Add("UsedMaterials", (transfer, value) => FUInt32Property.MoveValue(transfer, value.ToObject<UInt32>()));
            ///TransfersForName.Add("ValidClasses", (transfer, value) => FUInt32Property.MoveValue(transfer, value.ToObject<UInt32>()));
            ///TransfersForName.Add("ValidFolders", (transfer, value) => FNameProperty.MoveValue(transfer, value.ToObject<FName>()));
            ///TransfersForName.Add("Variations", (transfer, value) => FUInt32Property.MoveValue(transfer, value.ToObject<UInt32>()));
            ///TransfersForName.Add("VirtualProperties", (transfer, value) => FUInt32Property.MoveValue(transfer, value.ToObject<UInt32>()));
            ///TransfersForName.Add("VisitedNodes", (transfer, value) => FUInt32Property.MoveValue(transfer, value.ToObject<UInt32>()));
            ///TransfersForName.Add("WeakObjectPtrSet", (transfer, value) => FUInt32Property.MoveValue(transfer, value.ToObject<UInt32>()));
            #endregion

            #region Values found on Folder: Source - Failed
            ///TransfersForName.Add("ActiveDeviceProperties", (transfer, value) => FInputDevicePropertyHandle.MoveValue(transfer, value.ToObject<FInputDevicePropertyHandle>()));
            ///TransfersForName.Add("ActiveProperties", (transfer, value) => FActiveDeviceProperty.MoveValue(transfer, value.ToObject<FActiveDeviceProperty>()));
            ///TransfersForName.Add("EditColorSet", (transfer, value) => EPropertyEditorTestEditColor.MoveValue(transfer, value.ToObject<EPropertyEditorTestEditColor>()));
            ///TransfersForName.Add("ExcludedDataLayers", (transfer, value) => FActorDataLayer.MoveValue(transfer, value.ToObject<FActorDataLayer>()));
            ///TransfersForName.Add("LinearColorSet", (transfer, value) => FLinearColor.MoveValue(transfer, value.ToObject<FLinearColor>()));
            ///TransfersForName.Add("MarkedFrames_DEPRECATED", (transfer, value) => FFrameNumber.MoveValue(transfer, value.ToObject<FFrameNumber>()));
            ///TransfersForName.Add("ParameterInfoSet", (transfer, value) => FMaterialParameterInfo.MoveValue(transfer, value.ToObject<FMaterialParameterInfo>()));
            ///TransfersForName.Add("PropertiesPendingRemoval", (transfer, value) => FInputDevicePropertyHandle.MoveValue(transfer, value.ToObject<FInputDevicePropertyHandle>()));
            ///TransfersForName.Add("Set", (transfer, value) => FEditorConfigTestKey.MoveValue(transfer, value.ToObject<FEditorConfigTestKey>()));
            ///TransfersForName.Add("StructSet", (transfer, value) => FStructSerializerBuiltinTestStruct.MoveValue(transfer, value.ToObject<FStructSerializerBuiltinTestStruct>()));
            ///TransfersForName.Add("Trailings", (transfer, value) => FSolverTrailingData.MoveValue(transfer, value.ToObject<FSolverTrailingData>()));
            ///TransfersForName.Add("VectorSet", (transfer, value) => FVector.MoveValue(transfer, value.ToObject<FVector>()));
            ///TransfersForName.Add("VectorSet", (transfer, value) => FVector.MoveValue(transfer, value.ToObject<FVector>()));
            ///TransfersForName.Add("VectorSet", (transfer, value) => FVector3f.MoveValue(transfer, value.ToObject<FVector3f>()));
            ///TransfersForName.Add("ExcludedAssets", (transfer, value) => FSoftObjectPath.MoveValue(transfer, value.ToObject<FSoftObjectPath>()));
            ///TransfersForName.Add("RecursiveClassPathsExclusionSet", (transfer, value) => FTopLevelAssetPath.MoveValue(transfer, value.ToObject<FTopLevelAssetPath>()));
            #endregion

            #region Values found on Folder: Source - Failed
            ///TransfersForName.Add("ActorFolders", (transfer, value) => FUInt32Property.MoveValue(transfer, value.ToObject<UInt32>()));
            ///TransfersForName.Add("ActorSet", (transfer, value) => FUInt32Property.MoveValue(transfer, value.ToObject<UInt32>()));
            ///TransfersForName.Add("ActorTags", (transfer, value) => FNameProperty.MoveValue(transfer, value.ToObject<FName>()));
            ///TransfersForName.Add("AliasedStateNodes", (transfer, value) => FUInt32Property.MoveValue(transfer, value.ToObject<UInt32>()));
            ///TransfersForName.Add("AlwaysDynamicProperties", (transfer, value) => FNameProperty.MoveValue(transfer, value.ToObject<FName>()));
            ///TransfersForName.Add("AnimSequenceInstances", (transfer, value) => FGuid.MoveValue(transfer, value.ToObject<FGuid>()));
            ///TransfersForName.Add("CachedDependencies", (transfer, value) => FUInt32Property.MoveValue(transfer, value.ToObject<UInt32>()));
            ///TransfersForName.Add("CachedDependents", (transfer, value) => FUInt32Property.MoveValue(transfer, value.ToObject<UInt32>()));
            ///TransfersForName.Add("CachedUDSDependencies", (transfer, value) => FUInt32Property.MoveValue(transfer, value.ToObject<UInt32>()));
            ///TransfersForName.Add("ChaosHandlers", (transfer, value) => FUInt32Property.MoveValue(transfer, value.ToObject<UInt32>()));
            ///TransfersForName.Add("ChaosSolverActors", (transfer, value) => FUInt32Property.MoveValue(transfer, value.ToObject<UInt32>()));
            ///TransfersForName.Add("Components", (transfer, value) => FUInt32Property.MoveValue(transfer, value.ToObject<UInt32>()));
            ///TransfersForName.Add("ComponentsThatNeedPreEndOfFrameSync", (transfer, value) => FUInt32Property.MoveValue(transfer, value.ToObject<UInt32>()));
            ///TransfersForName.Add("ConcurrencySet", (transfer, value) => FUInt32Property.MoveValue(transfer, value.ToObject<UInt32>()));
            ///TransfersForName.Add("DataLayerInstances", (transfer, value) => FUInt32Property.MoveValue(transfer, value.ToObject<UInt32>()));
            ///TransfersForName.Add("Favorites", (transfer, value) => FStrProperty.MoveValue(transfer, value.ToObject<FString>()));
            ///TransfersForName.Add("FloatSet", (transfer, value) => FFloatProperty.MoveValue(transfer, value.ToObject<float>()));
            ///TransfersForName.Add("GeometryCollectionActors", (transfer, value) => FUInt32Property.MoveValue(transfer, value.ToObject<UInt32>()));
            ///TransfersForName.Add("ImportedNamespaces", (transfer, value) => FStrProperty.MoveValue(transfer, value.ToObject<FString>()));
            ///TransfersForName.Add("Int32Set", (transfer, value) => FIntProperty.MoveValue(transfer, value.ToObject<int>()));
            ///TransfersForName.Add("LandscapeSplinesAffectedComponents", (transfer, value) => FUInt32Property.MoveValue(transfer, value.ToObject<UInt32>()));
            ///TransfersForName.Add("Levels", (transfer, value) => FUInt32Property.MoveValue(transfer, value.ToObject<UInt32>()));
            ///TransfersForName.Add("Modulators", (transfer, value) => FUInt32Property.MoveValue(transfer, value.ToObject<UInt32>()));
            ///TransfersForName.Add("NameSet", (transfer, value) => FNameProperty.MoveValue(transfer, value.ToObject<FName>()));
            ///TransfersForName.Add("OverriddenSharedProperties", (transfer, value) => FStrProperty.MoveValue(transfer, value.ToObject<FString>()));
            ///TransfersForName.Add("PostProcessInstances", (transfer, value) => FGuid.MoveValue(transfer, value.ToObject<FGuid>()));
            ///TransfersForName.Add("PrereqIds", (transfer, value) => FStrProperty.MoveValue(transfer, value.ToObject<FString>()));
            ///TransfersForName.Add("ReferencedObjects", (transfer, value) => FUInt32Property.MoveValue(transfer, value.ToObject<UInt32>()));
            ///TransfersForName.Add("RegisteredEditorLoaderAdapters", (transfer, value) => FUInt32Property.MoveValue(transfer, value.ToObject<UInt32>()));
            ///TransfersForName.Add("RegisteredTranslatorsClass", (transfer, value) => FUInt32Property.MoveValue(transfer, value.ToObject<UInt32>()));
            ///TransfersForName.Add("RHIs", (transfer, value) => FNameProperty.MoveValue(transfer, value.ToObject<FName>()));
            ///TransfersForName.Add("SectionNames", (transfer, value) => FNameProperty.MoveValue(transfer, value.ToObject<FName>()));
            ///TransfersForName.Add("SelectedKeys", (transfer, value) => FIntProperty.MoveValue(transfer, value.ToObject<int>()));
            ///TransfersForName.Add("Set", (transfer, value) => FNameProperty.MoveValue(transfer, value.ToObject<FName>()));
            ///TransfersForName.Add("StrSet", (transfer, value) => FStrProperty.MoveValue(transfer, value.ToObject<FString>()));
            ///TransfersForName.Add("TemporarilyReferencedObjects", (transfer, value) => FUInt32Property.MoveValue(transfer, value.ToObject<UInt32>()));
            ///TransfersForName.Add("TypePromotionPinDenyList", (transfer, value) => FNameProperty.MoveValue(transfer, value.ToObject<FName>()));
            ///TransfersForName.Add("WorldDataLayers_DEPRECATED", (transfer, value) => FUInt32Property.MoveValue(transfer, value.ToObject<UInt32>()));
            #endregion
        }

        public static Dictionary<string, Func<Transfer, object, object>> Transfers { get; } = new();
        public static Dictionary<string, Func<Transfer, object, object>> TransfersForSetProperty { get; } = new();
    }
}
