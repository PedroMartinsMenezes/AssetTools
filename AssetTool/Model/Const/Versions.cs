namespace AssetTool
{
    public static class FUE5ReleaseStreamObjectVersion
    {
        public static readonly Guid Guid = new Guid("D89B5E42-24BD-4D46-8412-ACA8DF641779");

        public enum Enums
        {
            BeforeCustomVersionWasAdded = 0,
            ReflectionMethodEnum,
            WorldPartitionActorDescSerializeHLODInfo,
            RemovingTessellation,
            LevelInstanceSerializeRuntimeBehavior,
            PoseAssetRuntimeRefactor,
            WorldPartitionActorDescSerializeActorFolderPath,
            HairStrandsVertexFormatChange,
            AddChaosMaxLinearAngularSpeed,
            PackedLevelInstanceVersion,
            PackedLevelInstanceBoundsFix,
            CustomPropertyAnimGraphNodesUseOptionalPinManager,
            TextFormatArgumentData64bitSupport,
            MaterialLayerStacksAreNotParameters,
            MaterialInterfaceSavedCachedData,
            AddClothMappingLODBias,
            AddLevelActorPackagingScheme,
            WorldPartitionActorDescSerializeAttachParent,
            ConvertedActorGridPlacementToSpatiallyLoadedFlag,
            ActorGridPlacementDeprecateDefaultValueFixup,
            PackedLevelActorUseWorldPartitionActorDesc,
            AddLevelActorFolders,
            RemoveSkeletalMeshLODModelBulkDatas,
            ExcludeBrightnessFromEncodedHDRCubemap,
            VolumetricCloudSampleCountUnification,
            PoseAssetRawDataGUID,
            ConvolutionBloomIntensity,
            WorldPartitionHLODActorDescSerializeHLODSubActors,
            LargeWorldCoordinates,
            BlueprintPinsUseRealNumbers,
            UpdatedDirectionalLightShadowDefaults,
            GeometryCollectionConvexDefaults,
            ChaosClothFasterDamping,
            WorldPartitionLandscapeActorDescSerializeLandscapeActorGuid,
            AddedInertiaTensorAndRotationOfMassAddedToConvex,
            ChaosInertiaConvertedToVec3,
            SerializeFloatPinDefaultValuesAsSinglePrecision,
            AnimLayeredBoneBlendMasks,
            StoreReflectionCaptureEncodedHDRDataInRG11B10Format,
            RawAnimSequenceTrackSerializer,
            RemoveDuplicatedStyleInfo,
            LinkedAnimGraphMemberReference,
            DynamicMeshComponentsDefaultUseExternalTangents,
            MediaCaptureNewResizeMethods,
            RigVMSaveDebugMapInGraphFunctionData,
            LocalExposureDefaultChangeFrom1,
            WorldPartitionActorDescSerializeActorIsListedInSceneOutliner,
            OpenColorIODisabledDisplayConfigurationDefault,
            VersionPlusOne,
            LatestVersion = VersionPlusOne - 1
        }
    }

    public static class FCoreObjectVersion
    {
        public static readonly Guid Guid = new Guid("375EC13C-06E4-48FB-B500-84F0262A717E");

        public enum Enums
        {
            BeforeCustomVersionWasAdded = 0,
            MaterialInputNativeSerialize,
            EnumProperties,
            SkeletalMaterialEditorDataStripping,
            FProperties,
            VersionPlusOne,
            LatestVersion = VersionPlusOne - 1
        }
    }

    public static class FFrameworkObjectVersion
    {
        public static readonly Guid Guid = new Guid("CFFC743F-43B0-4480-9391-14DF171D2073");

        public enum Enums
        {
            BeforeCustomVersionWasAdded = 0,
            UseBodySetupCollisionProfile,
            AnimBlueprintSubgraphFix,
            MeshSocketScaleUtilization,
            ExplicitAttachmentRules,
            MoveCompressedAnimDataToTheDDC,
            FixNonTransactionalPins,
            SmartNameRefactor,
            AddSourceReferenceSkeletonToRig,
            ConstraintInstanceBehaviorParameters,
            PoseAssetSupportPerBoneMask,
            PhysAssetUseSkeletalBodySetup,
            RemoveSoundWaveCompressionName,
            AddInternalClothingGraphicalSkinning,
            WheelOffsetIsFromWheel,
            MoveCurveTypesToSkeleton,
            CacheDestructibleOverlaps,
            GeometryCacheMissingMaterials,
            LODsUseResolutionIndependentScreenSize,
            BlendSpacePostLoadSnapToGrid,
            SupportBlendSpaceRateScale,
            LODHysteresisUseResolutionIndependentScreenSize,
            ChangeAudioComponentOverrideSubtitlePriorityDefault,
            HardSoundReferences,
            EnforceConstInAnimBlueprintFunctionGraphs,
            InputKeySelectorTextStyle,
            EdGraphPinContainerType,
            ChangeAssetPinsToString,
            LocalVariablesBlueprintVisible,
            RemoveUField_Next,
            UserDefinedStructsBlueprintVisible,
            PinsStoreFName,
            UserDefinedStructsStoreDefaultInstance,
            FunctionTerminatorNodesUseMemberReference,
            EditableEventsUseConstRefParameters,
            BlueprintGeneratedClassIsAlwaysAuthoritative,
            EnforceBlueprintFunctionVisibility,
            StoringUCSSerializationIndex,
            VersionPlusOne,
            LatestVersion = VersionPlusOne - 1
        }
    }

    public static class FReleaseObjectVersion
    {
        public static readonly Guid Guid = new Guid("9C54D522-A826-4FBE-9421-074661B482D0");

        public enum Enums
        {
            BeforeCustomVersionWasAdded = 0,
            StaticMeshExtendedBoundsFix,
            NoSyncAsyncPhysAsset,
            LevelTransArrayConvertedToTArray,
            AddComponentNodeTemplateUniqueNames,
            UPropertryForMeshSectionSerialize,
            ConvertHLODScreenSize,
            SpeedTreeBillboardSectionInfoFixup,
            EventSectionParameterStringAssetRef,
            SkyLightRemoveMobileIrradianceMap,
            RenameNoTwistToAllowTwistInTwoBoneIK,
            MaterialLayersParameterSerializationRefactor,
            AddSkeletalMeshSectionDisable,
            RemovedMaterialSharedInputCollection,
            HISMCClusterTreeMigration,
            PinDefaultValuesVerified,
            FixBrokenStateMachineReferencesInTransitionGetters,
            MeshDescriptionNewSerialization,
            UnclampRGBColorCurves,
            LinkTimeAnimBlueprintRootDiscoveryBugFix,
            TrailNodeBlendVariableNameChange,
            PropertiesSerializeRepCondition,
            FocalDistanceDisablesDOF,
            Unused_SoundClass2DReverbSend,
            GroomAssetVersion1,
            GroomAssetVersion2,
            SerializeAnimModifierState,
            GroomAssetVersion3,
            DeprecateFilmbackSettings,
            CustomImplicitCollisionType,
            FFieldPathOwnerSerialization,
            MeshDescriptionNewFormat,
            PinTypeIncludesUObjectWrapperFlag,
            WeightFMeshToMeshVertData,
            AnimationGraphNodeBindingsDisplayedAsPins,
            SerializeRigVMOffsetSegmentPaths,
            AbcVelocitiesSupport,
            MarginAddedToConvexAndBox,
            StructureDataAddedToConvex,
            AddedFrontRightUpAxesToLiveLinkPreProcessor,
            FixupCopiedEventSections,
            RemoteControlSerializeFunctionArgumentsSize,
            AddedSubSequenceEntryWarpCounter,
            LonglatTextureCubeDefaultMaxResolution,
            GeometryCollectionCacheRemovesMassToLocal,
            VersionPlusOne,
            LatestVersion = VersionPlusOne - 1
        }
    }

    public static class FFortniteReleaseBranchCustomObjectVersion
    {
        public static readonly Guid Guid = new Guid("E7086368-6B23-4C58-8439-1B7016265E91");

        public enum Enums
        {
            BeforeCustomVersionWasAdded = 0,
            DisableLevelset_v14_10,
            ChaosClothAddTethersToCachedData,
            ChaosKinematicTargetRemoveScale,
            ActorComponentUCSModifiedPropertiesSparseStorage,
            FixupNaniteLandscapeMeshes,
            RemoveUselessLandscapeMeshesCookedCollisionData,
            SerializeAnimCurveCompressionCodecGuidOnCook,
            FixNaniteLandscapeMeshNames,
            LandscapeSharedPropertiesEnforcement,
            WorldPartitionRuntimeCellGuidWithCellSize,
            NaniteMaterialOverrideUsesEditorOnly,
            VersionPlusOne,
            LatestVersion = VersionPlusOne - 1
        }
    }

    public static class FUE5MainStreamObjectVersion
    {
        public static readonly Guid Guid = new Guid("697DD581-E64f-41AB-AA4A-51ECBEB7B628");

        public enum Enums
        {
            BeforeCustomVersionWasAdded = 0,
            GeometryCollectionNaniteData,
            GeometryCollectionNaniteDDC,
            RemovingSourceAnimationData,
            MeshDescriptionNewFormat,
            PartitionActorDescSerializeGridGuid,
            ExternalActorsMapDataPackageFlag,
            AnimationAddedBlendProfileModes,
            WorldPartitionActorDescSerializeDataLayers,
            RenamingAnimationNumFrames,
            WorldPartitionHLODActorDescSerializeHLODLayer,
            GeometryCollectionNaniteCooked,
            AddedCookedBoolFontFaceAssets,
            WorldPartitionHLODActorDescSerializeCellHash,
            GeometryCollectionNaniteTransient,
            AddedLandscapeSplineActorDesc,
            AddCollisionConstraintFlag,
            MantleDbSerialize,
            AnimSyncGroupsExplicitSyncMethod,
            FLandscapeActorDescFixupGridIndices,
            FoliageTypeIncludeInHLOD,
            IntroducingAnimationDataModel,
            WorldPartitionActorDescSerializeActorLabel,
            WorldPartitionActorDescSerializeArchivePersistent,
            FixForceExternalActorLevelReferenceDuplicates,
            SerializeMeshDescriptionBase,
            ConvexUsesVerticesArray,
            WorldPartitionActorDescSerializeHLODInfo,
            AddDisabledFlag,
            MoveCustomAttributesToDataModel,
            BlendSpaceRuntimeTriangulation,
            BlendSpaceSmoothingImprovements,
            RemovingTessellationParameters,
            SparseClassDataStructSerialization,
            PackedLevelInstanceBoundsFix,
            AnimNodeConstantDataRefactorPhase0,
            MaterialSavedCachedData,
            RemoveDecalBlendMode,
            DirLightsAreAtmosphereLightsByDefault,
            WorldPartitionStreamingCellsNamingShortened,
            WorldPartitionActorDescGetStreamingBounds,
            MeshDescriptionVirtualization,
            TextureSourceVirtualization,
            RigVMCopyOpStoreNumBytes,
            MaterialTranslucencyPass,
            GeometryCollectionUserDefinedCollisionShapes,
            RemovedAtmosphericFog,
            SkyAtmosphereAffectsHeightFogWithBetterDefault,
            BlendSpaceSampleOrdering,
            GeometryCollectionCacheRemovesMassToLocal,
            EdGraphPinSourceIndex,
            VirtualizedBulkDataHaveUniqueGuids,
            RigVMMemoryStorageObject,
            RayTracedShadowsType,
            SkelMeshSectionVisibleInRayTracingFlagAdded,
            AnimGraphNodeTaggingAdded,
            DynamicMeshCompactedSerialization,
            ConvertReductionBaseSkeletalMeshBulkDataToInlineReductionCacheData,
            SkeletalMeshLODModelMeshInfo,
            TextureDoScaleMipsForAlphaCoverage,
            VolumetricCloudReflectionSampleCountDefaultUpdate,
            UseTriangleMeshBVH,
            DynamicMeshAttributesWeightMapsAndNames,
            FKControlNamingScheme,
            RichCurveKeyInvalidTangentMode,
            ForceUpdateAnimationAssetCurveTangents,
            SoundWaveVirtualizationUpdate,
            MaterialFeatureLevelNodeFixForSM6,
            GeometryCollectionPerChildDamageThreshold,
            AddRigidParticleControlFlags,
            LiveLinkComponentPickerPerController,
            RemoveTriangleMeshBVHFaces,
            LensComponentNodalOffset,
            FixGpuAlwaysRunningUpdateScriptNoneInterpolated,
            WorldPartitionSerializeStreamingPolicyOnCook,
            WorldPartitionActorDescRemoveBoundsRelevantSerialization,
            AnimationDataModelInterface_BackedOut,
            LandscapeSplineActorDescDeprecation,
            BackoutAnimationDataModelInterface,
            MobileStationaryLocalLights,
            ManagedArrayCollectionAlwaysSerializeValue,
            LensComponentDistortion,
            ImgMediaPathResolutionWithEngineOrProjectTokens,
            AddLowResolutionHeightField,
            DecreaseLowResolutionHeightField,
            GeometryCollectionDamagePropagationData,
            VehicleFrictionForcePositionChange,
            AddSetMeshDeformerFlag,
            WorldPartitionActorDescActorAndClassPaths,
            ReintroduceAnimationDataModelInterface,
            IncreasedSkinWeightPrecision,
            MaterialHasIsUsedWithVolumetricCloudFlag,
            UpdateHairDescriptionBulkData,
            SpawnActorFromClassTransformScaleMethod,
            RigVMLazyEvaluation,
            PoseAssetRawDataGUIDUpdate,
            RigVMSaveFunctionAccessInModel,
            RigVMSerializeExecuteContextStruct,
            VisualLoggerTimeStampAsDouble,
            MaterialInstanceBasePropertyOverridesThinSurface,
            MaterialRefractionModeNone,
            RigVMSaveSerializedGraphInGraphFunctionData,
            PerPlatformAnimSequenceTargetFrameRate,
            NiagaraGrid2DDefaultUnnamedAttributesZero,
            RigVMGeneratedClass,
            NullPinSubCategoryObjectFix,
            AccessSpecifiersForCustomEvents,
            GroomAssetWidthOverride,
            AnimationRemoveSmartNames,
            NiagaraSpriteRendererFacingAlignmentAutoDefault,
            GroomAssetRemoveInAssetSerialization,
            IncreaseMaterialAttributesInputMask,
            NiagaraSimStageNumIterationsBindings,
            SkeletalVertexAttributes,
            RigVMExternalExecuteContextStruct,
            DataflowSeparateInputOutputSerialization,
            ClothCollectionTetherInitialization,
            OpenColorIOAssetCacheSerialization,
            ClothCollectionSingleLodSchema,
            VersionPlusOne,
            LatestVersion = VersionPlusOne - 1
        }
    }

    public static class FBlueprintsObjectVersion
    {
        public static readonly Guid Guid = new Guid("B0D832E4-1F89-4F0D-ACCF-7EB736FD4AA2");

        public enum Enums
        {
            BeforeCustomVersionWasAdded = 0,
            OverridenEventReferenceFixup,
            CleanBlueprintFunctionFlags,
            ArrayGetByRefUpgrade,
            EdGraphPinOptimized,
            AllowDeletionConformed,
            AdvancedContainerSupport,
            SCSHasComponentTemplateClass,
            ComponentTemplateClassSupport,
            ArrayGetFuncsReplacedByCustomNode,
            DisallowObjectConfigVars,
            VersionPlusOne,
            LatestVersion = VersionPlusOne - 1
        }
    }

    public static class FEditorObjectVersion
    {
        public static readonly Guid Guid = new Guid("E4B068ED-F494-42E9-A231-DA0B2E46BB41");

        public enum Enums
        {
            BeforeCustomVersionWasAdded = 0,
            GatheredTextProcessVersionFlagging,
            GatheredTextPackageCacheFixesV1,
            RootMetaDataSupport,
            GatheredTextPackageCacheFixesV2,
            TextFormatArgumentDataIsVariant,
            SplineComponentCurvesInStruct,
            ComboBoxControllerSupportUpdate,
            RefactorMeshEditorMaterials,
            AddedFontFaceAssets,
            UPropertryForMeshSection,
            WidgetGraphSchema,
            AddedBackgroundBlurContentSlot,
            StableUserDefinedEnumDisplayNames,
            AddedInlineFontFaceAssets,
            UPropertryForMeshSectionSerialize,
            FastWidgetTemplates,
            MaterialThumbnailRenderingChanges,
            NewSlateClippingSystem,
            MovieSceneMetaDataSerialization,
            GatheredTextEditorOnlyPackageLocId,
            AddedAlwaysSignNumberFormattingOption,
            AddedMaterialSharedInputs,
            AddedMorphTargetSectionIndices,
            SerializeInstancedStaticMeshRenderData,
            MeshDescriptionNewSerialization_MovedToRelease,
            MeshDescriptionNewAttributeFormat,
            ChangeSceneCaptureRootComponent,
            StaticMeshDeprecatedRawMesh,
            MeshDescriptionBulkDataGuid,
            MeshDescriptionRemovedHoles,
            ChangedWidgetComponentWindowVisibilityDefault,
            CultureInvariantTextSerializationKeyStability,
            ScrollBarThicknessChange,
            RemoveLandscapeHoleMaterial,
            MeshDescriptionTriangles,
            ComputeWeightedNormals,
            SkeletalMeshBuildRefactor,
            SkeletalMeshMoveEditorSourceDataToPrivateAsset,
            NumberParsingOptionsNumberLimitsAndClamping,
            SkeletalMeshSourceDataSupport16bitOfMaterialNumber,
            VersionPlusOne,
            LatestVersion = VersionPlusOne - 1
        }
    }
}
