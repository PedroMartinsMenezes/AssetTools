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

    public static class FRenderingObjectVersion
    {
        public static readonly Guid Guid = new Guid("12F88B9F-8875-4AFC-A67C-D90C383ABD29");

        public enum Enums
        {
            BeforeCustomVersionWasAdded = 0,
            IndirectLightingCache3BandSupport,
            CustomReflectionCaptureResolutionSupport,
            RemovedTextureStreamingLevelData,
            IntroducedMeshDecals,
            ReflectionCapturesStoreAverageBrightness,
            ChangedPlanarReflectionFadeDefaults,
            RemovedRenderTargetSize,
            MovedParticleCutoutsToRequiredModule,
            MapBuildDataSeparatePackage,
            TextureStreamingMeshUVChannelData,
            TypeHandlingForMaterialSqrtNodes,
            FixedBSPLightmaps,
            DistanceFieldSelfShadowBias,
            FixedLegacyMaterialAttributeNodeTypes,
            ShaderResourceCodeSharing,
            MotionBlurAndTAASupportInSceneCapture2d,
            AddedTextureRenderTargetFormats,
            FixedMeshUVDensity,
            AddedbUseShowOnlyList,
            VolumetricLightmaps,
            MaterialAttributeLayerParameters,
            StoreReflectionCaptureBrightnessForCooking,
            ModelVertexBufferSerialization,
            ReplaceLightAsIfStatic,
            ShaderPermutationId,
            IncreaseNormalPrecision,
            VirtualTexturedLightmaps,
            GeometryCacheFastDecoder,
            LightmapHasShadowmapData,
            DiaphragmDOFOnlyForDeferredShadingRenderer,
            VirtualTexturedLightmapsV2,
            SkyAtmosphereStaticLightingVersioning,
            ExplicitSRGBSetting,
            VolumetricLightmapStreaming,
            RemovedSM4,
            MaterialShaderMapIdSerialization,
            StaticMeshSectionForceOpaqueField,
            AutoExposureChanges,
            RemovedEmulatedInstancing,
            PerInstanceCustomData,
            AnisotropicMaterial,
            AutoExposureForceOverrideBiasFlag,
            AutoExposureDefaultFix,
            VolumeExtinctionBecomesRGB,
            VirtualTexturedLightmapsV3,
            NaniteFallbackTarget,
            NaniteForceMaterialUsage,
            VersionPlusOne,
            LatestVersion = VersionPlusOne - 1
        }
    }

    public static class FFortniteMainBranchObjectVersion
    {
        public static readonly Guid Guid = new Guid("601D1886-AC64-4F84-AA16-D3DE0DEAC7D6");

        public enum Enums
        {
            BeforeCustomVersionWasAdded = 0,
            WorldCompositionTile3DOffset,
            MaterialInstanceSerializeOptimization_ShaderFName,
            CullDistanceRefactor_RemovedDefaultDistance,
            CullDistanceRefactor_NeverCullHLODsByDefault,
            CullDistanceRefactor_NeverCullALODActorsByDefault,
            SaveGeneratedMorphTargetByEngine,
            ConvertReductionSettingOptions,
            StaticParameterTerrainLayerWeightBlendType,
            FixUpNoneNameAnimationCurves,
            EnsureActiveBoneIndicesToContainParents,
            SerializeInstancedStaticMeshRenderData,
            CachedMaterialQualityNodeUsage,
            FontOutlineDropShadowFixup,
            NewSkeletalMeshImporterWorkflow,
            NewLandscapeMaterialPerLOD,
            RemoveUnnecessaryTracksFromPose,
            FoliageLazyObjPtrToSoftObjPtr,
            REVERTED_StoreTimelineNamesInTemplate,
            AddBakePoseOverrideForSkeletalMeshReductionSetting,
            StoreTimelineNamesInTemplate,
            WidgetStopDuplicatingAnimations,
            AllowSkeletalMeshToReduceTheBaseLOD,
            ShrinkCurveTableSize,
            WidgetAnimationDefaultToSelfFail,
            FortHUDElementNowRequiresTag,
            FortMappedCookedAnimation,
            SupportVirtualBoneInRetargeting,
            FixUpWaterMetadata,
            MoveWaterMetadataToActor,
            ReplaceLakeCollision,
            AnimLayerGuidConformation,
            MakeOceanCollisionTransient,
            FFieldPathOwnerSerialization,
            FixUpUnderwaterPostProcessMaterial,
            SupportMultipleWaterBodiesPerExclusionVolume,
            RigVMByteCodeDeterminism,
            LandscapePhysicalMaterialRenderData,
            FixupRuntimeVirtualTextureVolume,
            FixUpRiverCollisionComponents,
            FixDuplicateRiverSplineMeshCollisionComponents,
            ContainsStableActorGUIDs,
            LevelsetSerializationSupportForBodySetup,
            ChaosSolverPropertiesMoved,
            GameFeatureData_MovedComponentListAndCheats,
            ChaosClothAddfictitiousforces,
            ChaosConvexVariableStructureDataAndVerticesArray,
            RemoveLandscapeWaterInfo,
            ChaosClothAddWeightedValue,
            ChaosClothAddTetherStiffnessWeightMap,
            ChaosClothFixLODTransitionMaps,
            ChaosClothAddTetherScaleAndDragLiftWeightMaps,
            ChaosClothAddMaterialWeightMaps,
            SerializeFloatChannelShowCurve,
            LandscapeGrassSingleArray,
            AddedSubSequenceEntryWarpCounter,
            WaterBodyComponentRefactor,
            BPGCCookedEditorTags,
            TerrainLayerWeightsAreNotParameters,
            GravityOverrideDefinedInWorldSpace,
            AnimDynamicsEditableChainParameters,
            WaterZonesRefactor,
            ChaosClothFasterDamping,
            MigratedFunctionHandlersToDefaults,
            ChaosInertiaConvertedToVec3,
            MigratedEventDefinitionToDefaults,
            LevelInstanceActorGuidSerialize,
            SingleFrameAndKeyAnimModel,
            RemappedEvaluateWorldPositionOffsetInRayTracing,
            WaterBodyComponentCollisionSettingsRefactor,
            WidgetInheritedNamedSlots,
            WaterHLODSupportAdded,
            PoseWatchMigrateSkeletonDrawParametersToPoseElement,
            WaterExclusionVolumeExcludeAllDefault,
            WaterNontessellatedLODSupportAdded,
            HierarchicalSimplificationMethodEnumAdded,
            WorldPartitionStreamingCellsNamingShortened,
            WorldPartitionActorDescSerializeContentBundleGuid,
            WorldPartitionActorDescSerializeActorIsRuntimeOnly,
            NaniteMaterialOverride,
            WorldPartitionHLODActorDescSerializeStats,
            WorldPartitionStreamingSourceComponentTargetDeprecation,
            FixedLocalizationGatherForExternalActorPackage,
            WorldPartitionHLODActorUseSourceCellGuid,
            ChaosGeometryCollectionInternalFacesAttribute,
            DynamicCastNodesUsePureStateEnum,
            WorldPartitionActorFilter,
            AudioAttenuationNonSpatializedRadiusBlend,
            WorldPartitionActorClassDescSerialize,
            WorldPartitionFActorContainerIDu64ToGuid,
            WorldPartitionPrivateDataLayers,
            ChaosImplicitObjectUnionBVHRefactor,
            LevelInstanceActorDescDeltaSerializeFilter,
            FixNaniteLandscapeMeshDDCKey,
            ChaosGeometryCollectionConnectionEdgeGroup,
            WaterBodyStaticMeshComponents,
            WorldPartitionActorDescSerializeInvalidBounds,
            NavigationLinkID32To64,
            WorldPartitionActorDescSerializeEditorOnlyReferences,
            WorldPartitionActorDescSerializeSoftObjectPathSupport,
            WorldPartitionClasDescGuidTransient,
            WorldPartitionActorDescIsMainWorldOnly,
            WorldPartitionActorFilterStringAssetPath,
            PackedLevelActorDesc,
            WorldPartitionRuntimeSpatialHashCVarOverrides,
            WorldPartitionHLODSourceActorsRefactor,
            WaterBodyStaticMeshRename,
            GeometryCollectionConvertVertexColorToSRGB,
            WaterOwningZonePointerFixup,
            WaterBodyStaticMeshDuplicateTransient,
            MVVMConvertPropertyPathToSkeletalClass,
            WaterBodyStaticMeshFixup,
            VersionPlusOne,
            LatestVersion = VersionPlusOne - 1
        }
    }

    public static class FSkeletalMeshCustomVersion
    {
        public static readonly Guid Guid = new Guid("D78A4A00-E858-4697-BAA8-19B5487D46B4");

        public enum Enums
        {
            BeforeCustomVersionWasAdded = 0,
            CombineSectionWithChunk = 1,
            CombineSoftAndRigidVerts = 2,
            RecalcMaxBoneInfluences = 3,
            SaveNumVertices = 4,
            RegenerateClothingShadowFlags = 5,
            UseSharedColorBufferFormat = 6,
            UseSeparateSkinWeightBuffer = 7,
            NewClothingSystemAdded = 8,
            CachedClothInverseMasses = 9,
            CompactClothVertexBuffer = 10,
            RemoveSourceData = 11,
            SplitModelAndRenderData = 12,
            RemoveTriangleSorting = 13,
            RemoveDuplicatedClothingSections = 14,
            DeprecateSectionDisabledFlag = 15,
            SectionIgnoreByReduceAdded = 16,
            SkinWeightProfiles = 17,
            RemoveEnableClothLOD = 18,
            VersionPlusOne,
            LatestVersion = VersionPlusOne - 1
        }
    }

    public static class FRecomputeTangentCustomVersion
    {
        public static readonly Guid Guid = new Guid("5579F886-933A-4C1F-83BA-087B6361B92F");

        public enum Enums
        {
            BeforeCustomVersionWasAdded = 0,
            RuntimeRecomputeTangent = 1,
            RecomputeTangentVertexColorMask = 2,
            VersionPlusOne,
            LatestVersion = VersionPlusOne - 1
        }
    }

    public static class FNiagaraObjectVersion
    {
        public static readonly Guid Guid = new Guid("F2AED0AC-9AFE-416F-8664-AA7FFA26D6FC");

        public enum Enums
        {
            BeforeCustomVersionWasAdded = 0,
            SkeletalMeshVertexSampling = 1,
            VersionPlusOne,
            LatestVersion = VersionPlusOne - 1
        }
    }

    public static class FAnimObjectVersion
    {
        public static readonly Guid Guid = new Guid("AF43A65D-7FD3-4947-9873-3E8ED9C1BB05");

        public enum Enums
        {
            BeforeCustomVersionWasAdded,
            LinkTimeAnimBlueprintRootDiscovery,
            StoreMarkerNamesOnSkeleton,
            SerializeRigVMRegisterArrayState,
            IncreaseBoneIndexLimitPerChunk,
            UnlimitedBoneInfluences,
            AnimSequenceCurveColors,
            NotifyAndSyncMarkerGuids,
            SerializeRigVMRegisterDynamicState,
            SerializeGroomCards,
            SerializeRigVMEntries,
            SerializeHairBindingAsset,
            SerializeHairClusterCullingData,
            SerializeGroomCardsAndMeshes,
            GroomLODStripping,
            GroomBindingSerialization,
            VersionPlusOne,
            LatestVersion = VersionPlusOne - 1
        }
    }

    public static class FOverlappingVerticesCustomVersion
    {
        public static readonly Guid Guid = new Guid("612FBE52-DA53-400B-910D-4F919FB1857C");

        public enum Enums
        {
            BeforeCustomVersionWasAdded = 0,
            DetectOVerlappingVertices = 1,
            VersionPlusOne,
            LatestVersion = VersionPlusOne - 1
        }
    }

    public static class FAnimPhysObjectVersion
    {
        public static readonly Guid Guid = new Guid("29E575DD-E0A3-4627-9D10-D276232CDCEA");

        public enum Enums
        {
            BeforeCustomVersionWasAdded,
            ConvertAnimNodeLookAtAxis,
            BoxSphylElemsUseRotators,
            ThumbnailSceneInfoAndAssetImportDataAreTransactional,
            AddedClothingMaskWorkflow,
            RemoveUIDFromSmartNameSerialize,
            CreateTargetReference,
            TuneSoftLimitStiffnessAndDamping,
            FixInvalidClothParticleMasses,
            CacheClothMeshInfluences,
            SmartNameRefactorForDeterministicCooking,
            RenameDisableAnimCurvesToAllowAnimCurveEvaluation,
            AddLODToCurveMetaData,
            FixupBadBlendProfileReferences,
            AllowMultipleAudioPluginSettings,
            ChangeRetargetSourceReferenceToSoftObjectPtr,
            SaveEditorOnlyFullPoseForPoseAsset,
            GeometryCacheAssetDeprecation,
            VersionPlusOne,
            LatestVersion = VersionPlusOne - 1
        }
    }

    public static class FNiagaraCustomVersion
    {
        public static readonly Guid Guid = new Guid("FCF57AFA-5076-4283-B9A9-E658FFA02D32");

        public enum Enums
        {
            BeforeCustomVersionWasAdded = 0,
            VMExternalFunctionBindingRework,
            PostLoadCompilationEnabled,
            VMExternalFunctionBindingReworkPartDeux,
            DataInterfacePerInstanceRework,
            NiagaraShaderMaps,
            UpdateSpawnEventGraphCombination,
            DataSetLayoutRework,
            AddedEmitterAndSystemScripts,
            ScriptExecutionContextRework,
            RemovalOfNiagaraVariableIDs,
            SystemEmitterScriptSimulations,
            IntegerRandom,
            AddedEmitterSpawnAttributes,
            NiagaraShaderMapCooking,
            NiagaraShaderMapCooking2,
            AddedScriptRapidIterationVariables,
            AddedTypeToDataInterfaceInfos,
            EnabledAutogeneratedDefaultValuesForFunctionCallNodes,
            CurveLUTNowOnByDefault,
            ScriptsNowUseAGuidForIdentificationInsteadOfAnIndex,
            NiagaraCombinedGPUSpawnUpdate,
            DontCompileGPUWhenNotNeeded,
            LifeCycleRework,
            NowSerializingReadWriteDataSets,
            TranslatorClearOutBetweenEmitters,
            AddSamplerDataInterfaceParams,
            GPUShadersForceRecompileNeeded,
            PlaybackRangeStoredOnSystem,
            MovedToDerivedDataCache,
            DataInterfacesNotAllocated,
            EmittersHaveGenericUniqueNames,
            MovingTranslatorVersionToGuid,
            AddingParamMapToDataSetBaseNode,
            DataInterfaceComputeShaderParamRefactor,
            CurveLUTRegen,
            AssignmentNodeUsesBeginDefaults,
            AssignmentNodeHasCorrectUsageBitmask,
            EmitterLocalSpaceLiteralConstant,
            TextureDataInterfaceUsesCustomSerialize,
            TextureDataInterfaceSizeSerialize,
            SkelMeshInterfaceAPIImprovements,
            ImproveLoadTimeFixupOfOpAddPins,
            MoveCommonInputMetadataToProperties,
            UseHashesToIdentifyCompileStateOfTopLevelScripts,
            MetaDataAndParametersUpdate,
            MoveInheritanceDataFromTheEmitterHandleToTheEmitter,
            AddLibraryAssetProperty,
            AddAdditionalDefinesProperty,
            RemoveGraphUsageCompileIds,
            AddRIAndDetailLevel,
            ChangeEmitterCompiledDataToSharedRefs,
            DisableSortingByDefault,
            MemorySaving,
            AddSimulationStageUsageEnum,
            AddGeneratedFunctionsToGPUParamInfo,
            PlatformScalingRefactor,
            PrecompileNamespaceFixup,
            FixNullScriptVariables,
            PrecompileNamespaceFixup2,
            SimulationStageInUsageBitmask,
            StandardizeParameterNames,
            ComponentsOnlyHaveUserVariables,
            RibbonRendererUVRefactor,
            VariablesUseTypeDefRegistry,
            AddLibraryVisibilityProperty,
            SignificanceHandlers,
            ModuleVersioning,
            MoveDefaultValueFromFNiagaraVariableMetaDataToUNiagaraScriptVariable,
            ChangeSystemDeterministicDefault,
            StaticSwitchFunctionPinsUsePersistentGuids,
            VisibilityCullingImprovements,
            AddBakerCameraBookmarks,
            PopulateFunctionCallNodePinNameBindings,
            ComponentRendererSpawnProperty,
            RepopulateFunctionCallNodePinNameBindings,
            EventSpawnsUpdateInitialAttributeValues,
            AddVariadicParametersToGPUFunctionInfo,
            DynamicPinNodeFixup,
            RibbonRendererLinkOrderDefaultIsUniqueID,
            VersionPlusOne,
            LatestVersion = VersionPlusOne - 1,
        }
    }

    public static class FMobileObjectVersion
    {
        public static readonly Guid Guid = new Guid("B02B49B5-BB20-44E9-A304-32B752E40360");

        public enum Enums
        {
            BeforeCustomVersionWasAdded = 0,
            InstancedStaticMeshLightmapSerialization,
            LQVolumetricLightmapLayers,
            StoreReflectionCaptureCompressedMobile,
            VersionPlusOne,
            LatestVersion = VersionPlusOne - 1
        }
    }

    public static class FReflectionCaptureObjectVersion
    {
        public static readonly Guid Guid = new Guid("6B266CEC-1EC7-4B8F-A30B-E4D90942FC07");

        public enum Enums
        {
            BeforeCustomVersionWasAdded = 0,
            MoveReflectionCaptureDataToMapBuildData,
            VersionPlusOne,
            LatestVersion = VersionPlusOne - 1
        }
    }

    public static class FSequencerObjectVersion
    {
        public static readonly Guid Guid = new Guid("7B5AE74C-D270-4C10-A958-57980B212A5A");

        public enum Enums
        {
            BeforeCustomVersionWasAdded = 0,
            RenameMediaSourcePlatformPlayers,
            ConvertEnableRootMotionToForceRootLock,
            ConvertMultipleRowsToTracks,
            WhenFinishedDefaultsToRestoreState,
            EvaluationTree,
            WhenFinishedDefaultsToProjectDefault,
            FloatToIntConversion,
            PurgeSpawnableBlueprints,
            FinishUMGEvaluation,
            SerializeFloatChannel,
            ModifyLinearKeysForOldInterp,
            SerializeFloatChannelCompletely,
            SpawnableImprovements,
            VersionPlusOne,
            LatestVersion = VersionPlusOne - 1
        }
    }

    public static class FControlRigObjectVersion
    {
        public static readonly Guid Guid = new Guid("A7820CFB-20A7-4359-8C54-2C149623CF50");

        public enum Enums
        {
            BeforeCustomVersionWasAdded,
            RemovalOfHierarchyRefPins,
            OperatorsStoringPropertyPaths,
            SwitchedToRigVM,
            ControlOffsetTransform,
            RigElementKeyCache,
            BlueprintVariableSupport,
            RigHierarchyV2,
            RigHierarchyMultiParentConstraints,
            RigHierarchyControlSpaceFavorites,
            StorageMinMaxValuesAsFloatStorage,
            RenameGizmoToShape,
            BoundVariableWithInjectionNode,
            PerChannelLimits,
            RemovedMultiParentParentCache,
            RemoveParameters,
            CurveElementValueStateFlag,
            ControlAnimationType,
            TemplatesPreferredPermutatation,
            PreferredEulerAnglesForControls,
            HierarchyElementMetadata,
            LibraryNodeTemplates,
            RestrictSpaceSwitchingForControls,
            ControlTransformChannelFiltering,
            StoreFunctionsInGeneratedClass,
            RigHierarchyStoringPreviousNames,
            RigHierarchyControlPreferredRotationOrder,
            RigHierarchyControlPreferredRotationOrderFlag,
            VersionPlusOne,
            LatestVersion = VersionPlusOne - 1
        }
    }

    public static class FRigVMObjectVersion
    {
        public static readonly Guid Guid = new Guid("DC49959B-53C0-4DE7-9156-EA885E7C5D39");

        public enum Enums
        {
            BeforeCustomVersionWasAdded,
            AddedVMHashChecks,
            PredicatesAddedToExecuteOps,
            VersionPlusOne,
            LatestVersion = VersionPlusOne - 1
        }
    }

    public static class FMediaFrameworkObjectVersion
    {
        public static readonly Guid Guid = new Guid("6f0ed827-a609-4895-9c91-998d90180ea4");

        public enum Enums
        {
            BeforeCustomVersionWasAdded = 0,
            SerializeGUIDsInMediaSourceInsteadOfPlainNames,
            SerializeGUIDsInPlatformMediaSourceInsteadOfPlainNames,
            VersionPlusOne,
            LatestVersion = VersionPlusOne - 1
        }
    }

    public static class FInterchangeCustomVersion
    {
        public static readonly Guid Guid = new Guid("92738C43-2988-4D9C-9A3D-9BBE6EFF9FC0");

        public enum Enums
        {
            BeforeCustomVersionWasAdded = 0,
            SerializedInterchangeObjectStoring,
            VersionPlusOne,
            LatestVersion = VersionPlusOne - 1
        }
    }

    public static class FLandscapeCustomVersion
    {
        public static readonly Guid Guid = new Guid("23AFE18E-4CE1-4E58-8D61-C252B953BEB7");

        public enum Enums
        {
            BeforeCustomVersionWasAdded = 0,
            NewSplineCrossLevelMeshSerialization,
            GrassMaterialWPO,
            CollisionMaterialWPO,
            LightmassMaterialWPO,
            GrassMaterialInstanceFix,
            SplineForeignDataLazyObjectPtrFix,
            MigrateOldPropertiesToNewRenderingProperties,
            AddingBodyInstanceToSplinesElements,
            AddSplineLayerFalloff,
            AddSplineLayerWidth,
            NewLandscapeContinuousLOD,
            VersionPlusOne,
            LatestVersion = VersionPlusOne - 1
        }
    }

    public static class FUE5PrivateFrostyStreamObjectVersion
    {
        public static readonly Guid Guid = new Guid("59DA5D52-1232-4948-B878-597870B8E98B");

        public enum Enums
        {
            BeforeCustomVersionWasAdded = 0,
            HLODBatchingPolicy,
            SerializeSceneComponentStaticBounds,
            ChaosClothAddTethersToCachedData,
            SerializeActorLabelInCookedBuilds,
            ConvertWorldPartitionHLODsCellsToName,
            ChaosClothRemoveKinematicTethers,
            SerializeSkeletalMeshMorphTargetRenderData,
            StripMorphTargetSourceDataForCookedBuilds,
            VersionPlusOne,
            LatestVersion = VersionPlusOne - 1
        }
    }

    public static class FComputeFrameworkObjectVersion
    {
        public static readonly Guid Guid = new Guid("6304a3e7-0059-4f59-8cfc-21bd7721fd4e");

        public enum Enums
        {
            InitialVersion = 0,
            VersionPlusOne,
            LatestVersion = VersionPlusOne - 1
        }
    }
}
