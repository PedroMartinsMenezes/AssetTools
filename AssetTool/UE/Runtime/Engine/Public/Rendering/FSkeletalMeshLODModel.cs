namespace AssetTool
{
    public class FSkeletalMeshLODModel : ITransferible
    {
        public FStripDataFlags StripFlags = new();
        public List<FSkelMeshSection> Sections;
        public Dictionary<TInt32, FSkelMeshSourceSectionUserData> UserSectionsData;
        public FMultiSizeIndexContainer TempMultiSizeIndexContainer;
        public List<UInt32> IndexBuffer;
        public List<FBoneIndexType> ActiveBoneIndices;
        public List<FSkelMeshImportedMeshInfo> ImportedMeshInfos;
        public List<FLegacySkelMeshChunk> LegacyChunks;
        public UInt32 LegacySize;
        public UInt32 NumVertices;
        public List<FBoneIndexType> RequiredBones;
        public FIntBulkData RawPointIndices_DEPRECATED;
        public List<UInt32> RawPointIndices2;
        public FRawSkeletalMeshBulkData RawSkeletalMeshBulkData_DEPRECATED;
        public FString RawSkeletalMeshBulkDataID;
        public FBool bIsBuildDataAvailable;
        public FBool bIsRawSkeletalMeshBulkDataEmpty;
        public List<Int32> TempMeshToImportVertexMap;
        public Int32 TempMaxImportVertex;
        public List<Int32> MeshToImportVertexMap;
        public Int32 MaxImportVertex;
        public UInt32 NumTexCoords;
        public FDummySkeletalMeshVertexBuffer DummyVertexBuffer;
        public FSkinWeightVertexBuffer DummyWeightBuffer;
        public Dictionary<FName, FImportedSkinWeightProfileData> SkinWeightProfiles;

        [Location("void FSkeletalMeshLODModel::Serialize(FArchive& Ar, UObject* Owner, int32 Idx)")]
        public ITransferible Move(Transfer transfer)
        {
            StripFlags.Move(transfer);
            if (StripFlags.IsDataStrippedForServer())
            {
                throw new NotImplementedException();
            }
            else
            {
                transfer.Move(ref Sections);

                if (!StripFlags.IsEditorDataStripped() && Supports.CustomVer(FEditorObjectVersion.Enums.SkeletalMeshBuildRefactor))
                {
                    transfer.Move(ref UserSectionsData, key => key.Move(transfer), value => value.Move(transfer));
                }
                if (!Supports.CustomVer(FSkeletalMeshCustomVersion.Enums.SplitModelAndRenderData))
                {
                    TempMultiSizeIndexContainer ??= new();
                    TempMultiSizeIndexContainer.Move(transfer);
                }
                else if (!StripFlags.IsEditorDataStripped())
                {
                    transfer.Move(ref IndexBuffer);
                }
                transfer.Move(ref ActiveBoneIndices);//14577
                if (!StripFlags.IsEditorDataStripped() && Supports.SkeletalMeshLODModelMeshInfo)
                {
                    transfer.Move(ref ImportedMeshInfos);
                }
            }
            if (!Supports.CombineSectionWithChunk)
            {
                transfer.Move(ref LegacyChunks);
            }
            transfer.Move(ref LegacySize);
            if (!StripFlags.IsDataStrippedForServer())
            {
                transfer.Move(ref NumVertices);
            }
            transfer.Move(ref RequiredBones);
            if (!StripFlags.IsEditorDataStripped())
            {
                if (!Supports.RemoveSkeletalMeshLODModelBulkDatas)
                {
                    transfer.Move(ref RawPointIndices_DEPRECATED);
                }
                else
                {
                    transfer.Move(ref RawPointIndices2);
                }
                if (Supports.NewSkeletalMeshImporterWorkflow && !Supports.SkeletalMeshMoveEditorSourceDataToPrivateAsset)
                {
                    transfer.Move(ref RawSkeletalMeshBulkData_DEPRECATED);
                }
                if (Supports.SkeletalMeshMoveEditorSourceDataToPrivateAsset)//14695
                {
                    transfer.Move(ref RawSkeletalMeshBulkDataID);
                    transfer.Move(ref bIsBuildDataAvailable);
                    transfer.Move(ref bIsRawSkeletalMeshBulkDataEmpty);
                }
            }
            if (StripFlags.IsDataStrippedForServer())
            {
                transfer.Move(ref TempMeshToImportVertexMap);
                transfer.Move(ref TempMaxImportVertex);
            }
            else
            {
                transfer.Move(ref MeshToImportVertexMap);
                transfer.Move(ref MaxImportVertex);
            }
            if (!StripFlags.IsDataStrippedForServer())
            {
                transfer.Move(ref NumTexCoords);
                if (!Supports.SplitModelAndRenderData)
                {
                    transfer.Move(ref DummyVertexBuffer);
                    if (Supports.UseSeparateSkinWeightBuffer)
                    {
                        transfer.Move(ref DummyWeightBuffer);
                    }
                    throw new NotImplementedException();
                }
            }
            if (Supports.SkinWeightProfiles)
            {
                SkinWeightProfiles.Move(transfer, key => transfer.Move(key), value => value.Move(transfer));
            }
            return this;
        }

        public class FSkelMeshSection : Transferible<FSkelMeshSection>
        {
            public FStripDataFlags StripFlags = new();
            public UInt16 MaterialIndex;
            public UInt16 DummyChunkIndex;
            public UInt32 BaseIndex;
            public UInt32 NumTriangles;
            public byte DummyTriangleSorting;
            public FBool bLegacyClothingSection_DEPRECATED;
            public Int16 CorrespondClothSectionIndex_DEPRECATED;
            public byte DummyEnableClothLOD;
            public FBool bRecomputeTangent;
            public ESkinVertexColorChannel RecomputeTangentsVertexMaskChannel;
            public FBool bCastShadow;
            public FBool bVisibleInRayTracing;
            public UInt32 BaseVertexIndex;
            public List<FLegacyRigidSkinVertex> LegacyRigidVertices;
            public List<FSoftSkinVertex> SoftVertices;
            public FBool bUse16BitBoneIndex;
            public List<FBoneIndexType> BoneMap;
            public Int32 NumVertices;
            public Int32 DummyNumRigidVerts;
            public Int32 DummyNumSoftVerts;
            public Int32 MaxBoneInfluences;
            public List<List<FMeshToMeshVertData>> ClothMappingDataLODs;
            public List<FVector> DummyArray1;
            public List<FVector> DummyArray2;
            public Int16 CorrespondClothAssetIndex;
            public Int16 DummyClothAssetSubmeshIndex;
            public FClothingSectionData ClothingData;
            public Dictionary<TInt32, List<TInt32>> OverlappingVertices;
            public FBool bDisabled;
            public Int32 GenerateUpToLodIndex;
            public Int32 OriginalDataSectionIndex;
            public Int32 ChunkedParentSectionIndex;

            [Location("FArchive& operator<<(FArchive& Ar, FSkelMeshSection& S)")]
            public override ITransferible Move(Transfer transfer)
            {
                StripFlags.Move(transfer);
                transfer.Move(ref MaterialIndex);
                if (!Supports.CustomVer(FSkeletalMeshCustomVersion.Enums.CombineSectionWithChunk))
                    transfer.Move(ref DummyChunkIndex);
                if (!StripFlags.IsDataStrippedForServer())
                    transfer.Move(ref BaseIndex);
                if (!StripFlags.IsDataStrippedForServer())
                    transfer.Move(ref NumTriangles);
                if (!Supports.CustomVer(FSkeletalMeshCustomVersion.Enums.RemoveTriangleSorting))
                    transfer.Move(ref DummyTriangleSorting);
                if (Supports.UEVer(EUnrealEngineObjectUE4Version.VER_UE4_APEX_CLOTH))
                {
                    if (!Supports.CustomVer(FSkeletalMeshCustomVersion.Enums.DeprecateSectionDisabledFlag))
                        transfer.Move(ref bLegacyClothingSection_DEPRECATED);
                    if (!Supports.CustomVer(FSkeletalMeshCustomVersion.Enums.RemoveDuplicatedClothingSections))
                        transfer.Move(ref CorrespondClothSectionIndex_DEPRECATED);
                }
                if (Supports.UEVer(EUnrealEngineObjectUE4Version.VER_UE4_APEX_CLOTH_LOD))
                {
                    if (!Supports.CustomVer(FSkeletalMeshCustomVersion.Enums.RemoveEnableClothLOD))
                        transfer.Move(ref DummyEnableClothLOD);
                }
                if (Supports.CustomVer(FRecomputeTangentCustomVersion.Enums.RuntimeRecomputeTangent))
                    transfer.Move(ref bRecomputeTangent);
                if (Supports.CustomVer(FRecomputeTangentCustomVersion.Enums.RecomputeTangentVertexColorMask))
                    RecomputeTangentsVertexMaskChannel = (ESkinVertexColorChannel)transfer.Move((byte)RecomputeTangentsVertexMaskChannel);
                if (Supports.CustomVer(FEditorObjectVersion.Enums.RefactorMeshEditorMaterials))
                    transfer.Move(ref bCastShadow);
                if (Supports.CustomVer(FUE5MainStreamObjectVersion.Enums.SkelMeshSectionVisibleInRayTracingFlagAdded))
                    transfer.Move(ref bVisibleInRayTracing);
                if (Supports.CustomVer(FSkeletalMeshCustomVersion.Enums.CombineSectionWithChunk))
                {
                    if (!StripFlags.IsDataStrippedForServer())
                        transfer.Move(ref BaseVertexIndex);
                    if (!StripFlags.IsEditorDataStripped())
                    {
                        if (!Supports.CustomVer(FSkeletalMeshCustomVersion.Enums.CombineSoftAndRigidVerts))
                        {
                            LegacyRigidVertices ??= new();
                            LegacyRigidVertices.Resize(transfer);
                            LegacyRigidVertices.ForEach(x => x.Move(transfer));
                        }
                        SoftVertices ??= new();
                        SoftVertices.Resize(transfer);
                        SoftVertices.ForEach(x => x.Move(transfer));

                    }
                    if (Supports.CustomVer(FAnimObjectVersion.Enums.IncreaseBoneIndexLimitPerChunk))
                        transfer.Move(ref bUse16BitBoneIndex);
                    BoneMap ??= new();
                    BoneMap.Resize(transfer);
                    BoneMap.ForEach(x => transfer.Move(ref x));
                    if (Supports.CustomVer(FSkeletalMeshCustomVersion.Enums.SaveNumVertices))
                        transfer.Move(ref NumVertices);
                    if (!Supports.CustomVer(FSkeletalMeshCustomVersion.Enums.CombineSoftAndRigidVerts))
                    {
                        transfer.Move(ref DummyNumRigidVerts);
                        transfer.Move(ref DummyNumSoftVerts);
                    }
                    transfer.Move(ref MaxBoneInfluences);
                    if (!Supports.CustomVer(FUE5ReleaseStreamObjectVersion.Enums.AddClothMappingLODBias))
                    {
                        ClothMappingDataLODs ??= new();
                        ClothMappingDataLODs.Resize(transfer, 1);
                        ClothMappingDataLODs[0].Move(transfer, item => item.Move(transfer));
                    }
                    else
                    {
                        ClothMappingDataLODs ??= new();
                        ClothMappingDataLODs.Resize(transfer);
                        ClothMappingDataLODs.ForEach(list => list.Move(transfer, (item) => item.Move(transfer)));
                    }
                    if (!Supports.CustomVer(FSkeletalMeshCustomVersion.Enums.RemoveDuplicatedClothingSections))
                    {
                        DummyArray1 ??= new();
                        DummyArray1.Move(transfer, x => x.Move(transfer));
                        DummyArray2 ??= new();
                        DummyArray2.Move(transfer, x => x.Move(transfer));
                    }
                    transfer.Move(ref CorrespondClothAssetIndex);
                    if (!Supports.CustomVer(FSkeletalMeshCustomVersion.Enums.NewClothingSystemAdded))
                    {
                        transfer.Move(ref DummyClothAssetSubmeshIndex);
                    }
                    else
                    {
                        ClothingData ??= new();
                        ClothingData.Move(transfer);
                    }
                    if (Supports.CustomVer(FOverlappingVerticesCustomVersion.Enums.DetectOVerlappingVertices))
                    {
                        OverlappingVertices ??= new();
                        OverlappingVertices.Resize(transfer);
                        foreach (var pair in OverlappingVertices)
                        {
                            pair.Key.Move(transfer);
                            pair.Value.Resize(transfer);
                            pair.Value.ForEach(x => x.Move(transfer));
                        }
                    }
                    if (Supports.CustomVer(FReleaseObjectVersion.Enums.AddSkeletalMeshSectionDisable))
                        transfer.Move(ref bDisabled);
                    if (Supports.CustomVer(FSkeletalMeshCustomVersion.Enums.SectionIgnoreByReduceAdded))
                        transfer.Move(ref GenerateUpToLodIndex);
                    if (Supports.CustomVer(FEditorObjectVersion.Enums.SkeletalMeshBuildRefactor))
                    {
                        transfer.Move(ref OriginalDataSectionIndex);
                        transfer.Move(ref ChunkedParentSectionIndex);
                    }
                }
                return this;
            }
        }

        public class FLegacyRigidSkinVertex
        {
            public FVector3f Position = new();
            public FVector3f TangentX;
            public FVector3f TangentY;
            public FVector3f TangentZ;
            public FDeprecatedSerializedPackedNormal TempTangentX;
            public FDeprecatedSerializedPackedNormal TempTangentY;
            public FDeprecatedSerializedPackedNormal TempTangentZ;
            public FVector2f[] UVs = new FVector2f[Consts.MAX_TEXCOORDS];
            public FColor Color = new();
            public byte Bone;

            [Location("operator<<(FArchive& Ar, FLegacyRigidSkinVertex& V)")]
            public void Move(Transfer transfer)
            {
                Position.Move(transfer);
                if (!Supports.CustomVer(FRenderingObjectVersion.Enums.IncreaseNormalPrecision))
                {
                    TempTangentX ??= new();
                    TempTangentX.Move(transfer);
                    TempTangentY ??= new();
                    TempTangentY.Move(transfer);
                    TempTangentZ ??= new();
                    TempTangentZ.Move(transfer);
                }
                else
                {
                    TangentX ??= new();
                    TangentX.Move(transfer);
                    TangentY ??= new();
                    TangentY.Move(transfer);
                    TangentZ ??= new();
                    TangentZ.Move(transfer);
                }
                for (int UVIdx = 0; UVIdx < Consts.MAX_TEXCOORDS; ++UVIdx)
                {
                    UVs[UVIdx] ??= new();
                    UVs[UVIdx].Move(transfer);
                }
                Color.Move(transfer);
                transfer.Move(ref Bone);
            }
        }

        public class FSoftSkinVertex
        {
            public FVector3f Position = new();
            public FVector3f TangentX;
            public FVector3f TangentY;
            public FVector4f TangentZ;
            public FDeprecatedSerializedPackedNormal TempTangentX;
            public FDeprecatedSerializedPackedNormal TempTangentY;
            public FDeprecatedSerializedPackedNormal TempTangentZ;
            public FVector2f[] UVs = new FVector2f[Consts.MAX_TEXCOORDS];
            public FColor Color = new();
            public FBoneIndexType[] InfluenceBones = new FBoneIndexType[Consts.MAX_TOTAL_INFLUENCES];
            public UInt16[] InfluenceWeights = new UInt16[Consts.MAX_TOTAL_INFLUENCES];
            public byte[] Bone = new byte[Consts.MAX_INFLUENCES_PER_STREAM];
            public byte[] BoneIndex = new byte[Consts.MAX_INFLUENCES_PER_STREAM];
            public byte[] OldInfluence = new byte[Consts.MAX_TOTAL_INFLUENCES];

            [Location("operator<<(FArchive& Ar, FSoftSkinVertex& V)")]
            public void Move(Transfer transfer)
            {
                Position.Move(transfer);
                if (!Supports.CustomVer(FRenderingObjectVersion.Enums.IncreaseNormalPrecision))
                {
                    TempTangentX ??= new();
                    TempTangentX.Move(transfer);
                    TempTangentY ??= new();
                    TempTangentY.Move(transfer);
                    TempTangentZ ??= new();
                    TempTangentZ.Move(transfer);
                }
                else
                {
                    TangentX ??= new();
                    TangentX.Move(transfer);
                    TangentY ??= new();
                    TangentY.Move(transfer);
                    TangentZ ??= new();
                    TangentZ.Move(transfer);
                }
                for (int UVIdx = 0; UVIdx < Consts.MAX_TEXCOORDS; ++UVIdx)
                {
                    UVs[UVIdx] ??= new();
                    UVs[UVIdx].Move(transfer);
                }
                Color.Move(transfer);
                bool bBeforeIncreaseBoneIndexLimitPerChunk = !Supports.CustomVer(FAnimObjectVersion.Enums.IncreaseBoneIndexLimitPerChunk);

                for (int i = 0; i < Consts.MAX_INFLUENCES_PER_STREAM; i++)
                {
                    if (bBeforeIncreaseBoneIndexLimitPerChunk)
                        transfer.Move(ref Bone[i]);
                    else
                        transfer.Move(ref InfluenceBones[i]);
                }
                if (Supports.UEVer(EUnrealEngineObjectUE4Version.VER_UE4_SUPPORT_8_BONE_INFLUENCES_SKELETAL_MESHES))
                {
                    for (int i = Consts.MAX_INFLUENCES_PER_STREAM; i < Consts.EXTRA_BONE_INFLUENCES; i++)
                    {
                        if (bBeforeIncreaseBoneIndexLimitPerChunk)
                            transfer.Move(ref BoneIndex[i]);
                        else
                            transfer.Move(ref InfluenceBones[i]);
                    }
                }
                if (Supports.CustomVer(FAnimObjectVersion.Enums.UnlimitedBoneInfluences))
                {
                    for (int i = Consts.EXTRA_BONE_INFLUENCES; i < Consts.MAX_TOTAL_INFLUENCES; i++)
                        transfer.Move(ref InfluenceBones[i]);
                }
                if (Supports.CustomVer(FUE5MainStreamObjectVersion.Enums.IncreasedSkinWeightPrecision))
                {
                    for (int i = 0; i < Consts.MAX_TOTAL_INFLUENCES; i++)
                    {
                        transfer.Move(ref InfluenceWeights[i]);
                    }
                }
                else
                {
                    int MaxInfluences = Consts.MAX_INFLUENCES_PER_STREAM;
                    if (Supports.CustomVer(FAnimObjectVersion.Enums.UnlimitedBoneInfluences))
                        MaxInfluences = Consts.MAX_TOTAL_INFLUENCES;
                    else if (Supports.UEVer(EUnrealEngineObjectUE4Version.VER_UE4_SUPPORT_8_BONE_INFLUENCES_SKELETAL_MESHES))
                        MaxInfluences = Consts.EXTRA_BONE_INFLUENCES;

                    for (int i = 0; i < MaxInfluences; i++)
                        transfer.Move(ref OldInfluence[i]);
                }
            }
        }

        public class FSkelMeshSourceSectionUserData
        {
            public FStripDataFlags StripFlags = new();
            public FBool bRecomputeTangent;
            public ESkinVertexColorChannel RecomputeTangentsVertexMaskChannel;
            public FBool bCastShadow;
            public FBool bVisibleInRayTracing;
            public Int16 CorrespondClothAssetIndex;
            public FClothingSectionData ClothingData = new();
            public FBool bDisabled;
            public Int32 GenerateUpToLodIndex;

            public void Move(Transfer transfer)
            {
                StripFlags.Move(transfer);
                transfer.Move(ref bRecomputeTangent);
                if (Supports.CustomVer(FRecomputeTangentCustomVersion.Enums.RecomputeTangentVertexColorMask))
                {
                    RecomputeTangentsVertexMaskChannel = (ESkinVertexColorChannel)transfer.Move((byte)RecomputeTangentsVertexMaskChannel);
                }
                transfer.Move(ref bCastShadow);
                if (Supports.CustomVer(FUE5MainStreamObjectVersion.Enums.SkelMeshSectionVisibleInRayTracingFlagAdded))
                {
                    transfer.Move(ref bVisibleInRayTracing);
                }
                transfer.Move(ref bDisabled);
                transfer.Move(ref GenerateUpToLodIndex);
                transfer.Move(ref CorrespondClothAssetIndex);
                ClothingData.Move(transfer);
            }
        }

        public class FSkelMeshImportedMeshInfo : ITransferible
        {
            public FName Name;
            public Int32 NumVertices;
            public Int32 StartImportedVertex;

            public ITransferible Move(Transfer transfer)
            {
                transfer.Move(ref Name);
                transfer.Move(ref NumVertices);
                transfer.Move(ref StartImportedVertex);
                return this;
            }
        }

        public class FLegacySkelMeshChunk : ITransferible
        {
            public FStripDataFlags StripFlags = new();
            public UInt32 BaseVertexIndex;
            public List<FSoftSkinVertex> SoftVertices;
            public List<FMeshToMeshVertData> ApexClothMappingData;
            public List<FVector> PhysicalMeshVertices;
            public List<FVector> PhysicalMeshNormals;
            public List<FBoneIndexType> BoneMap;
            public Int32 MaxBoneInfluences;
            public Int16 CorrespondClothAssetIndex;
            public Int16 ClothAssetSubmeshIndex;

            public ITransferible Move(Transfer transfer)
            {
                StripFlags.Move(transfer);
                return this;
            }
        }
    }
}
