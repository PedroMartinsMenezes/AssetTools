namespace AssetTool
{
    public static class Supports
    {
        #region EUnrealEngineObjectUE4Version
        public static bool VER_UE4_PROPERTY_TAG_SET_MAP_SUPPORT => GlobalObjects.UESupport(EUnrealEngineObjectUE4Version.VER_UE4_PROPERTY_TAG_SET_MAP_SUPPORT);
        public static bool VER_UE4_STRUCT_GUID_IN_PROPERTY_TAG => GlobalObjects.UESupport(EUnrealEngineObjectUE4Version.VER_UE4_STRUCT_GUID_IN_PROPERTY_TAG);
        public static bool VAR_UE4_ARRAY_PROPERTY_INNER_TAGS => GlobalObjects.UESupport(EUnrealEngineObjectUE4Version.VAR_UE4_ARRAY_PROPERTY_INNER_TAGS);
        public static bool VER_UE4_TemplateIndex_IN_COOKED_EXPORTS => GlobalObjects.UESupport(EUnrealEngineObjectUE4Version.VER_UE4_TemplateIndex_IN_COOKED_EXPORTS);
        public static bool VER_UE4_64BIT_EXPORTMAP_SERIALSIZES => GlobalObjects.UESupport(EUnrealEngineObjectUE4Version.VER_UE4_64BIT_EXPORTMAP_SERIALSIZES);
        public static bool VER_UE4_LOAD_FOR_EDITOR_GAME => GlobalObjects.UESupport(EUnrealEngineObjectUE4Version.VER_UE4_LOAD_FOR_EDITOR_GAME);
        public static bool VER_UE4_COOKED_ASSETS_IN_EDITOR_SUPPORT => GlobalObjects.UESupport(EUnrealEngineObjectUE4Version.VER_UE4_COOKED_ASSETS_IN_EDITOR_SUPPORT);
        public static bool VER_UE4_PRELOAD_DEPENDENCIES_IN_COOKED_EXPORTS => GlobalObjects.UESupport(EUnrealEngineObjectUE4Version.VER_UE4_PRELOAD_DEPENDENCIES_IN_COOKED_EXPORTS);
        public static bool VER_UE4_NON_OUTER_PACKAGE_IMPORT => GlobalObjects.UESupport(EUnrealEngineObjectUE4Version.VER_UE4_NON_OUTER_PACKAGE_IMPORT);
        public static bool VER_UE4_PURGED_FMATERIAL_COMPILE_OUTPUTS => GlobalObjects.UESupport(EUnrealEngineObjectUE4Version.VER_UE4_PURGED_FMATERIAL_COMPILE_OUTPUTS);
        public static bool VER_UE4_STORE_HASCOOKEDDATA_FOR_BODYSETUP => GlobalObjects.UESupport(EUnrealEngineObjectUE4Version.VER_UE4_STORE_HASCOOKEDDATA_FOR_BODYSETUP);
        #endregion

        #region EUnrealEngineObjectUE5Version
        public static bool OPTIONAL_RESOURCES => GlobalObjects.UESupport(EUnrealEngineObjectUE5Version.OPTIONAL_RESOURCES);
        public static bool TRACK_OBJECT_EXPORT_IS_INHERITED => GlobalObjects.UESupport(EUnrealEngineObjectUE5Version.TRACK_OBJECT_EXPORT_IS_INHERITED);
        public static bool REMOVE_OBJECT_EXPORT_PACKAGE_GUID => GlobalObjects.UESupport(EUnrealEngineObjectUE5Version.REMOVE_OBJECT_EXPORT_PACKAGE_GUID);
        public static bool LARGE_WORLD_COORDINATES => GlobalObjects.UESupport(EUnrealEngineObjectUE5Version.LARGE_WORLD_COORDINATES);
        #endregion

        public static bool IsCompatible() => GlobalObjects.UESupport(EUnrealEngineObjectUE4Version.VER_UE4_OLDEST_LOADABLE_PACKAGE);

        #region UEVer
        public static int UEVer4() => GlobalObjects.PackageFileSummary.FileVersionUE.FileVersionUE4;
        public static int UEVer5() => GlobalObjects.PackageFileSummary.FileVersionUE.FileVersionUE5;
        public static bool UEVer(EUnrealEngineObjectUE4Version value) => GlobalObjects.UESupport(value);
        public static bool UEVer(EUnrealEngineObjectUE5Version value) => GlobalObjects.UESupport(value);
        #endregion

        #region EUnrealEngineObjectUE4Version
        public static bool VER_UE4_REFERENCE_SKELETON_REFACTOR => Supports.UEVer(EUnrealEngineObjectUE4Version.VER_UE4_REFERENCE_SKELETON_REFACTOR);
        public static bool VER_UE4_APEX_CLOTH => Supports.UEVer(EUnrealEngineObjectUE4Version.VER_UE4_APEX_CLOTH);
        public static bool VER_UE4_FIX_ANIMATIONBASEPOSE_SERIALIZATION => Supports.UEVer(EUnrealEngineObjectUE4Version.VER_UE4_FIX_ANIMATIONBASEPOSE_SERIALIZATION);
        public static bool VER_UE4_SKELETON_GUID_SERIALIZATION => Supports.UEVer(EUnrealEngineObjectUE4Version.VER_UE4_SKELETON_GUID_SERIALIZATION);
        public static bool VER_UE4_SKELETON_ADD_SMARTNAMES => Supports.UEVer(EUnrealEngineObjectUE4Version.VER_UE4_SKELETON_ADD_SMARTNAMES);
        public static bool VER_UE4_SOUND_COMPRESSION_TYPE_ADDED => Supports.UEVer(EUnrealEngineObjectUE4Version.VER_UE4_SOUND_COMPRESSION_TYPE_ADDED);
        public static bool VER_UE4_ANIMATION_ADD_TRACKCURVES => Supports.UEVer(EUnrealEngineObjectUE4Version.VER_UE4_ANIMATION_ADD_TRACKCURVES);
        public static bool VER_UE4_SERIALIZE_LANDSCAPE_GRASS_DATA => Supports.UEVer(EUnrealEngineObjectUE4Version.VER_UE4_SERIALIZE_LANDSCAPE_GRASS_DATA);
        public static bool VER_UE4_SERIALIZE_LANDSCAPE_GRASS_DATA_MATERIAL_GUID => Supports.UEVer(EUnrealEngineObjectUE4Version.VER_UE4_SERIALIZE_LANDSCAPE_GRASS_DATA_MATERIAL_GUID);
        public static bool VER_UE4_LANDSCAPE_PLATFORMDATA_COOKING => Supports.UEVer(EUnrealEngineObjectUE4Version.VER_UE4_LANDSCAPE_PLATFORMDATA_COOKING);
        public static bool VER_UE4_LANDSCAPE_COLLISION_DATA_COOKING => Supports.UEVer(EUnrealEngineObjectUE4Version.VER_UE4_LANDSCAPE_COLLISION_DATA_COOKING);
        #endregion

        #region CustomVer
        public static bool CustomVer(FCoreObjectVersion.Enums value) => GlobalObjects.CustomVer(FCoreObjectVersion.Guid) >= (int)value;
        public static bool CustomVer(FFrameworkObjectVersion.Enums value) => GlobalObjects.CustomVer(FFrameworkObjectVersion.Guid) >= (int)value;
        public static bool CustomVer(FReleaseObjectVersion.Enums value) => GlobalObjects.CustomVer(FReleaseObjectVersion.Guid) >= (int)value;
        public static bool CustomVer(FFortniteReleaseBranchCustomObjectVersion.Enums value) => GlobalObjects.CustomVer(FFortniteReleaseBranchCustomObjectVersion.Guid) >= (int)value;
        public static bool CustomVer(FUE5MainStreamObjectVersion.Enums value) => GlobalObjects.CustomVer(FUE5MainStreamObjectVersion.Guid) >= (int)value;
        public static bool CustomVer(FBlueprintsObjectVersion.Enums value) => GlobalObjects.CustomVer(FBlueprintsObjectVersion.Guid) >= (int)value;
        public static bool CustomVer(FEditorObjectVersion.Enums value) => GlobalObjects.CustomVer(FEditorObjectVersion.Guid) >= (int)value;
        public static bool CustomVer(FUE5ReleaseStreamObjectVersion.Enums value) => GlobalObjects.CustomVer(FUE5ReleaseStreamObjectVersion.Guid) >= (int)value;
        public static bool CustomVer(FRenderingObjectVersion.Enums value) => GlobalObjects.CustomVer(FRenderingObjectVersion.Guid) >= (int)value;
        public static bool CustomVer(FFortniteMainBranchObjectVersion.Enums value) => GlobalObjects.CustomVer(FFortniteMainBranchObjectVersion.Guid) >= (int)value;
        public static bool CustomVer(FSkeletalMeshCustomVersion.Enums value) => GlobalObjects.CustomVer(FSkeletalMeshCustomVersion.Guid) >= (int)value;
        public static bool CustomVer(FRecomputeTangentCustomVersion.Enums value) => GlobalObjects.CustomVer(FRecomputeTangentCustomVersion.Guid) >= (int)value;
        public static bool CustomVer(FNiagaraObjectVersion.Enums value) => GlobalObjects.CustomVer(FNiagaraObjectVersion.Guid) >= (int)value;
        public static bool CustomVer(FAnimObjectVersion.Enums value) => GlobalObjects.CustomVer(FAnimObjectVersion.Guid) >= (int)value;
        public static bool CustomVer(FOverlappingVerticesCustomVersion.Enums value) => GlobalObjects.CustomVer(FOverlappingVerticesCustomVersion.Guid) >= (int)value;
        public static bool CustomVer(FAnimPhysObjectVersion.Enums value) => GlobalObjects.CustomVer(FAnimPhysObjectVersion.Guid) >= (int)value;
        public static bool CustomVer(FNiagaraCustomVersion.Enums value) => GlobalObjects.CustomVer(FNiagaraCustomVersion.Guid) >= (int)value;
        public static bool CustomVer(FMobileObjectVersion.Enums value) => GlobalObjects.CustomVer(FMobileObjectVersion.Guid) >= (int)value;
        public static bool CustomVer(FReflectionCaptureObjectVersion.Enums value) => GlobalObjects.CustomVer(FReflectionCaptureObjectVersion.Guid) >= (int)value;
        public static bool CustomVer(FSequencerObjectVersion.Enums value) => GlobalObjects.CustomVer(FSequencerObjectVersion.Guid) >= (int)value;
        public static bool CustomVer(FControlRigObjectVersion.Enums value) => GlobalObjects.CustomVer(FControlRigObjectVersion.Guid) >= (int)value;
        public static bool CustomVer(FRigVMObjectVersion.Enums value) => GlobalObjects.CustomVer(FRigVMObjectVersion.Guid) >= (int)value;
        public static bool CustomVer(FMediaFrameworkObjectVersion.Enums value) => GlobalObjects.CustomVer(FMediaFrameworkObjectVersion.Guid) >= (int)value;
        public static bool CustomVer(FInterchangeCustomVersion.Enums value) => GlobalObjects.CustomVer(FInterchangeCustomVersion.Guid) >= (int)value;
        public static bool CustomVer(FLandscapeCustomVersion.Enums value) => GlobalObjects.CustomVer(FLandscapeCustomVersion.Guid) >= (int)value;
        public static bool CustomVer(FUE5PrivateFrostyStreamObjectVersion.Enums value) => GlobalObjects.CustomVer(FUE5PrivateFrostyStreamObjectVersion.Guid) >= (int)value;
        #endregion

        #region FUE5MainStreamObjectVersion
        public static bool SkeletalMeshLODModelMeshInfo => CustomVer(FUE5MainStreamObjectVersion.Enums.SkeletalMeshLODModelMeshInfo);
        public static bool ConvertReductionBaseSkeletalMeshBulkDataToInlineReductionCacheData => CustomVer(FUE5MainStreamObjectVersion.Enums.ConvertReductionBaseSkeletalMeshBulkDataToInlineReductionCacheData);
        public static bool MaterialSavedCachedData => CustomVer(FUE5MainStreamObjectVersion.Enums.MaterialSavedCachedData);
        public static bool SoundWaveVirtualizationUpdate => CustomVer(FUE5MainStreamObjectVersion.Enums.SoundWaveVirtualizationUpdate);
        public static bool MobileStationaryLocalLights => CustomVer(FUE5MainStreamObjectVersion.Enums.MobileStationaryLocalLights);
        public static bool SparseClassDataStructSerialization => CustomVer(FUE5MainStreamObjectVersion.Enums.SparseClassDataStructSerialization);
        public static bool RigVMSaveSerializedGraphInGraphFunctionData => CustomVer(FUE5MainStreamObjectVersion.Enums.RigVMSaveSerializedGraphInGraphFunctionData);
        public static bool RigVMGeneratedClass => CustomVer(FUE5MainStreamObjectVersion.Enums.RigVMGeneratedClass);
        public static bool RigVMMemoryStorageObject => CustomVer(FUE5MainStreamObjectVersion.Enums.RigVMMemoryStorageObject);
        public static bool RigVMExternalExecuteContextStruct => CustomVer(FUE5MainStreamObjectVersion.Enums.RigVMExternalExecuteContextStruct);
        public static bool RigVMSerializeExecuteContextStruct => CustomVer(FUE5MainStreamObjectVersion.Enums.RigVMSerializeExecuteContextStruct);
        public static bool IncreasedSkinWeightPrecision => CustomVer(FUE5MainStreamObjectVersion.Enums.IncreasedSkinWeightPrecision);
        public static bool RemovingSourceAnimationData => CustomVer(FUE5MainStreamObjectVersion.Enums.RemovingSourceAnimationData);
        public static bool RigVMCopyOpStoreNumBytes => CustomVer(FUE5MainStreamObjectVersion.Enums.RigVMCopyOpStoreNumBytes);
        public static bool RigVMLazyEvaluation => CustomVer(FUE5MainStreamObjectVersion.Enums.RigVMLazyEvaluation);
        public static bool AddedCookedBoolFontFaceAssets => CustomVer(FUE5MainStreamObjectVersion.Enums.AddedCookedBoolFontFaceAssets);
        #endregion
        #region FSkeletalMeshCustomVersion
        public static bool CombineSectionWithChunk => CustomVer(FSkeletalMeshCustomVersion.Enums.CombineSectionWithChunk);
        public static bool SplitModelAndRenderData => CustomVer(FSkeletalMeshCustomVersion.Enums.SplitModelAndRenderData);
        public static bool UseSeparateSkinWeightBuffer => CustomVer(FSkeletalMeshCustomVersion.Enums.UseSeparateSkinWeightBuffer);
        public static bool SkinWeightProfiles => CustomVer(FSkeletalMeshCustomVersion.Enums.SkinWeightProfiles);
        public static bool RemoveSourceData => CustomVer(FSkeletalMeshCustomVersion.Enums.RemoveSourceData);
        public static bool NewClothingSystemAdded => CustomVer(FSkeletalMeshCustomVersion.Enums.NewClothingSystemAdded);
        #endregion
        #region FUE5ReleaseStreamObjectVersion
        public static bool RemoveSkeletalMeshLODModelBulkDatas => CustomVer(FUE5ReleaseStreamObjectVersion.Enums.RemoveSkeletalMeshLODModelBulkDatas);
        public static bool MaterialInterfaceSavedCachedData => CustomVer(FUE5ReleaseStreamObjectVersion.Enums.MaterialInterfaceSavedCachedData);
        public static bool ExcludeBrightnessFromEncodedHDRCubemap => CustomVer(FUE5ReleaseStreamObjectVersion.Enums.ExcludeBrightnessFromEncodedHDRCubemap);
        public static bool StoreReflectionCaptureEncodedHDRDataInRG11B10Format => CustomVer(FUE5ReleaseStreamObjectVersion.Enums.StoreReflectionCaptureEncodedHDRDataInRG11B10Format);
        public static bool RigVMSaveDebugMapInGraphFunctionData => CustomVer(FUE5ReleaseStreamObjectVersion.Enums.RigVMSaveDebugMapInGraphFunctionData);
        #endregion
        #region FFortniteMainBranchObjectVersion
        public static bool NewSkeletalMeshImporterWorkflow => CustomVer(FFortniteMainBranchObjectVersion.Enums.NewSkeletalMeshImporterWorkflow);
        public static bool AllowSkeletalMeshToReduceTheBaseLOD => CustomVer(FFortniteMainBranchObjectVersion.Enums.AllowSkeletalMeshToReduceTheBaseLOD);
        private static bool SerializeInstancedStaticMeshRenderData2 => CustomVer(FFortniteMainBranchObjectVersion.Enums.SerializeInstancedStaticMeshRenderData);
        public static bool SerializeFloatChannelShowCurve => CustomVer(FFortniteMainBranchObjectVersion.Enums.SerializeFloatChannelShowCurve);
        public static bool BPGCCookedEditorTags => CustomVer(FFortniteMainBranchObjectVersion.Enums.BPGCCookedEditorTags);
        public static bool RigVMByteCodeDeterminism => CustomVer(FFortniteMainBranchObjectVersion.Enums.RigVMByteCodeDeterminism);
        public static bool LandscapeGrassSingleArray => CustomVer(FFortniteMainBranchObjectVersion.Enums.LandscapeGrassSingleArray);
        public static bool LandscapePhysicalMaterialRenderData => CustomVer(FFortniteMainBranchObjectVersion.Enums.LandscapePhysicalMaterialRenderData);
        #endregion
        #region FEditorObjectVersion
        private static bool SerializeInstancedStaticMeshRenderData1 => CustomVer(FEditorObjectVersion.Enums.SerializeInstancedStaticMeshRenderData);
        public static bool SkeletalMeshMoveEditorSourceDataToPrivateAsset => CustomVer(FEditorObjectVersion.Enums.SkeletalMeshMoveEditorSourceDataToPrivateAsset);
        public static bool SkeletalMeshBuildRefactor => CustomVer(FEditorObjectVersion.Enums.SkeletalMeshBuildRefactor);
        private static bool UPropertryForMeshSectionSerialize1 => CustomVer(FEditorObjectVersion.Enums.UPropertryForMeshSectionSerialize);
        public static bool AddedFontFaceAssets => CustomVer(FEditorObjectVersion.Enums.AddedFontFaceAssets);
        public static bool AddedInlineFontFaceAssets => CustomVer(FEditorObjectVersion.Enums.AddedInlineFontFaceAssets);
        #endregion
        #region FAnimObjectVersion
        public static bool UnlimitedBoneInfluences => CustomVer(FAnimObjectVersion.Enums.UnlimitedBoneInfluences);
        public static bool StoreMarkerNamesOnSkeleton => CustomVer(FAnimObjectVersion.Enums.StoreMarkerNamesOnSkeleton);
        public static bool IncreaseBoneIndexLimitPerChunk => CustomVer(FAnimObjectVersion.Enums.IncreaseBoneIndexLimitPerChunk);
        public static bool SerializeRigVMEntries => CustomVer(FAnimObjectVersion.Enums.SerializeRigVMEntries);
        #endregion
        #region FRenderingObjectVersion
        public static bool TextureStreamingMeshUVChannelData => CustomVer(FRenderingObjectVersion.Enums.TextureStreamingMeshUVChannelData);
        public static bool MapBuildDataSeparatePackage => CustomVer(FRenderingObjectVersion.Enums.MapBuildDataSeparatePackage);
        public static bool NaniteForceMaterialUsage => CustomVer(FRenderingObjectVersion.Enums.NaniteForceMaterialUsage);
        public static bool VolumetricLightmaps => CustomVer(FRenderingObjectVersion.Enums.VolumetricLightmaps);
        public static bool PerInstanceCustomData => CustomVer(FRenderingObjectVersion.Enums.PerInstanceCustomData);
        public static bool SkyAtmosphereStaticLightingVersioning => CustomVer(FRenderingObjectVersion.Enums.SkyAtmosphereStaticLightingVersioning);
        public static bool StoreReflectionCaptureBrightnessForCooking => CustomVer(FRenderingObjectVersion.Enums.StoreReflectionCaptureBrightnessForCooking);
        public static bool VolumetricLightmapStreaming => CustomVer(FRenderingObjectVersion.Enums.VolumetricLightmapStreaming);
        public static bool MovedParticleCutoutsToRequiredModule => CustomVer(FRenderingObjectVersion.Enums.MovedParticleCutoutsToRequiredModule);
        #endregion
        #region FFrameworkObjectVersion
        public static bool SmartNameRefactor => CustomVer(FFrameworkObjectVersion.Enums.SmartNameRefactor);
        public static bool MoveCurveTypesToSkeleton => CustomVer(FFrameworkObjectVersion.Enums.MoveCurveTypesToSkeleton);
        public static bool RemoveSoundWaveCompressionName => CustomVer(FFrameworkObjectVersion.Enums.RemoveSoundWaveCompressionName);
        public static bool AddSourceReferenceSkeletonToRig => CustomVer(FFrameworkObjectVersion.Enums.AddSourceReferenceSkeletonToRig);
        public static bool PinsStoreFName => CustomVer(FFrameworkObjectVersion.Enums.PinsStoreFName);
        public static bool HardSoundReferences => CustomVer(FFrameworkObjectVersion.Enums.HardSoundReferences);
        #endregion
        #region FAnimPhysObjectVersion
        public static bool SmartNameRefactorForDeterministicCooking => CustomVer(FAnimPhysObjectVersion.Enums.SmartNameRefactorForDeterministicCooking);
        public static bool AddLODToCurveMetaData => CustomVer(FAnimPhysObjectVersion.Enums.AddLODToCurveMetaData);
        public static bool RemoveUIDFromSmartNameSerialize => CustomVer(FAnimPhysObjectVersion.Enums.RemoveUIDFromSmartNameSerialize);
        #endregion
        #region FBlueprintsObjectVersion
        public static bool EdGraphPinOptimized => CustomVer(FBlueprintsObjectVersion.Enums.EdGraphPinOptimized);
        #endregion
        #region FNiagaraCustomVersion
        public static bool VariablesUseTypeDefRegistry => CustomVer(FNiagaraCustomVersion.Enums.VariablesUseTypeDefRegistry);
        public static bool AddGeneratedFunctionsToGPUParamInfo => CustomVer(FNiagaraCustomVersion.Enums.AddGeneratedFunctionsToGPUParamInfo);
        public static bool AddVariadicParametersToGPUFunctionInfo => CustomVer(FNiagaraCustomVersion.Enums.AddVariadicParametersToGPUFunctionInfo);
        public static bool NiagaraShaderMaps => CustomVer(FNiagaraCustomVersion.Enums.NiagaraShaderMaps);
        public static bool NiagaraShaderMapCooking => CustomVer(FNiagaraCustomVersion.Enums.NiagaraShaderMapCooking);
        public static bool DontCompileGPUWhenNotNeeded => CustomVer(FNiagaraCustomVersion.Enums.DontCompileGPUWhenNotNeeded);
        public static bool NiagaraShaderMapCooking2 => CustomVer(FNiagaraCustomVersion.Enums.NiagaraShaderMapCooking2);
        public static bool NiagaraCombinedGPUSpawnUpdate => CustomVer(FNiagaraCustomVersion.Enums.NiagaraCombinedGPUSpawnUpdate);
        public static bool MovedToDerivedDataCache => CustomVer(FNiagaraCustomVersion.Enums.MovedToDerivedDataCache);
        public static bool UseHashesToIdentifyCompileStateOfTopLevelScripts => CustomVer(FNiagaraCustomVersion.Enums.UseHashesToIdentifyCompileStateOfTopLevelScripts);
        public static bool ChangeEmitterCompiledDataToSharedRefs => CustomVer(FNiagaraCustomVersion.Enums.ChangeEmitterCompiledDataToSharedRefs);
        #endregion
        #region FMobileObjectVersion
        public static bool InstancedStaticMeshLightmapSerialization => CustomVer(FMobileObjectVersion.Enums.InstancedStaticMeshLightmapSerialization);
        public static bool StoreReflectionCaptureCompressedMobile => CustomVer(FMobileObjectVersion.Enums.StoreReflectionCaptureCompressedMobile);
        public static bool LQVolumetricLightmapLayers => CustomVer(FMobileObjectVersion.Enums.LQVolumetricLightmapLayers);
        #endregion
        #region FReflectionCaptureObjectVersion
        public static bool MoveReflectionCaptureDataToMapBuildData => CustomVer(FReflectionCaptureObjectVersion.Enums.MoveReflectionCaptureDataToMapBuildData);
        #endregion
        #region FFortniteReleaseBranchCustomObjectVersion
        public static bool ActorComponentUCSModifiedPropertiesSparseStorage => CustomVer(FFortniteReleaseBranchCustomObjectVersion.Enums.ActorComponentUCSModifiedPropertiesSparseStorage);
        #endregion
        #region FSequencerObjectVersion
        public static bool SerializeFloatChannelCompletely => CustomVer(FSequencerObjectVersion.Enums.SerializeFloatChannelCompletely);
        public static bool SerializeFloatChannel => CustomVer(FSequencerObjectVersion.Enums.SerializeFloatChannel);
        public static bool RenameMediaSourcePlatformPlayers => CustomVer(FSequencerObjectVersion.Enums.RenameMediaSourcePlatformPlayers);
        #endregion
        #region FControlRigObjectVersion
        public static bool SwitchedToRigVM => CustomVer(FControlRigObjectVersion.Enums.SwitchedToRigVM);
        public static bool StoreFunctionsInGeneratedClass => CustomVer(FControlRigObjectVersion.Enums.StoreFunctionsInGeneratedClass);
        public static bool HierarchyElementMetadata => CustomVer(FControlRigObjectVersion.Enums.HierarchyElementMetadata);
        public static bool RigHierarchyStoringPreviousNames => CustomVer(FControlRigObjectVersion.Enums.RigHierarchyStoringPreviousNames);
        public static bool RemovedMultiParentParentCache => CustomVer(FControlRigObjectVersion.Enums.RemovedMultiParentParentCache);
        public static bool RigHierarchyMultiParentConstraints => CustomVer(FControlRigObjectVersion.Enums.RigHierarchyMultiParentConstraints);
        public static bool PreferredEulerAnglesForControls => CustomVer(FControlRigObjectVersion.Enums.PreferredEulerAnglesForControls);
        public static bool ControlAnimationType => CustomVer(FControlRigObjectVersion.Enums.ControlAnimationType);
        public static bool PerChannelLimits => CustomVer(FControlRigObjectVersion.Enums.PerChannelLimits);
        public static bool StorageMinMaxValuesAsFloatStorage => CustomVer(FControlRigObjectVersion.Enums.StorageMinMaxValuesAsFloatStorage);
        public static bool RenameGizmoToShape => CustomVer(FControlRigObjectVersion.Enums.RenameGizmoToShape);
        public static bool RigHierarchyControlSpaceFavorites => CustomVer(FControlRigObjectVersion.Enums.RigHierarchyControlSpaceFavorites);
        public static bool RestrictSpaceSwitchingForControls => CustomVer(FControlRigObjectVersion.Enums.RestrictSpaceSwitchingForControls);
        public static bool ControlTransformChannelFiltering => CustomVer(FControlRigObjectVersion.Enums.ControlTransformChannelFiltering);
        public static bool RigHierarchyControlPreferredRotationOrder => CustomVer(FControlRigObjectVersion.Enums.RigHierarchyControlPreferredRotationOrder);
        public static bool RigHierarchyControlPreferredRotationOrderFlag => CustomVer(FControlRigObjectVersion.Enums.RigHierarchyControlPreferredRotationOrderFlag);
        public static bool CurveElementValueStateFlag => CustomVer(FControlRigObjectVersion.Enums.CurveElementValueStateFlag);
        #endregion
        #region FRigVMObjectVersion
        public static bool BeforeCustomVersionWasAdded => CustomVer(FRigVMObjectVersion.Enums.BeforeCustomVersionWasAdded);
        public static bool AddedVMHashChecks => CustomVer(FRigVMObjectVersion.Enums.AddedVMHashChecks);
        public static bool PredicatesAddedToExecuteOps => CustomVer(FRigVMObjectVersion.Enums.PredicatesAddedToExecuteOps);
        #endregion
        #region FReleaseObjectVersion
        private static bool UPropertryForMeshSectionSerialize2 => CustomVer(FReleaseObjectVersion.Enums.UPropertryForMeshSectionSerialize);
        #endregion
        #region FCoreObjectVersion
        public static bool MaterialInputNativeSerialize => CustomVer(FCoreObjectVersion.Enums.MaterialInputNativeSerialize);
        #endregion
        #region FMediaFrameworkObjectVersion
        public static bool SerializeGUIDsInMediaSourceInsteadOfPlainNames => CustomVer(FMediaFrameworkObjectVersion.Enums.SerializeGUIDsInMediaSourceInsteadOfPlainNames);
        #endregion
        #region FInterchangeCustomVersion
        public static bool SerializedInterchangeObjectStoring => CustomVer(FInterchangeCustomVersion.Enums.SerializedInterchangeObjectStoring);
        #endregion
        #region FNiagaraObjectVersion
        public static bool SkeletalMeshVertexSampling => CustomVer(FNiagaraObjectVersion.Enums.SkeletalMeshVertexSampling);
        #endregion
        #region FLandscapeCustomVersion
        public static bool GrassMaterialInstanceFix => CustomVer(FLandscapeCustomVersion.Enums.GrassMaterialInstanceFix);
        public static bool GrassMaterialWPO => CustomVer(FLandscapeCustomVersion.Enums.GrassMaterialWPO);
        public static bool CollisionMaterialWPO => CustomVer(FLandscapeCustomVersion.Enums.CollisionMaterialWPO);
        public static bool LightmassMaterialWPO => CustomVer(FLandscapeCustomVersion.Enums.LightmassMaterialWPO);
        #endregion
        #region FUE5PrivateFrostyStreamObjectVersion
        public static bool SerializeSceneComponentStaticBounds => CustomVer(FUE5PrivateFrostyStreamObjectVersion.Enums.SerializeSceneComponentStaticBounds);
        #endregion

        #region Repeated
        public static bool SerializeInstancedStaticMeshRenderData => SerializeInstancedStaticMeshRenderData1 || SerializeInstancedStaticMeshRenderData2;
        public static bool UPropertryForMeshSectionSerialize => UPropertryForMeshSectionSerialize1 || UPropertryForMeshSectionSerialize2;
        #endregion
    }
}
