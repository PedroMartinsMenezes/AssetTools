using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace AssetTool
{
    public class FSkeletalMeshLODModel : ITransferible
    {
        public FStripDataFlags StripFlags;
        public List<FSkelMeshSection> Sections;
        public Dictionary<TInt32, FSkelMeshSourceSectionUserData> UserSectionsData;
        public FMultiSizeIndexContainer TempMultiSizeIndexContainer;
        public UInt32[] IndexBuffer;
        public FBoneIndexType[] ActiveBoneIndices;
        public List<FSkelMeshImportedMeshInfo> ImportedMeshInfos;
        public List<FLegacySkelMeshChunk> LegacyChunks;
        public UInt32 LegacySize;
        public UInt32 NumVertices;
        public FBoneIndexType[] RequiredBones;
        public FIntBulkData RawPointIndices_DEPRECATED;
        public UInt32[] RawPointIndices2;
        public FRawSkeletalMeshBulkData RawSkeletalMeshBulkData_DEPRECATED;
        public FString RawSkeletalMeshBulkDataID;
        public FBool bIsBuildDataAvailable;
        public FBool bIsRawSkeletalMeshBulkDataEmpty;
        public Int32[] TempMeshToImportVertexMap;
        public Int32 TempMaxImportVertex;
        public Int32[] MeshToImportVertexMap;
        public Int32 MaxImportVertex;
        public UInt32 NumTexCoords;
        public FDummySkeletalMeshVertexBuffer DummyVertexBuffer;
        public FSkinWeightVertexBuffer DummyWeightBuffer;
        public Dictionary<FName, FImportedSkinWeightProfileData> SkinWeightProfiles;
        public FMultiSizeIndexContainer TempMultiSizeAdjacencyIndexContainer;
        public FStripDataFlags StripFlags2;
        public TBulkList<FMeshToMeshVertData> DummyClothData;
        public uint64[] DummyIndexMapping;

        [Location("void FSkeletalMeshLODModel::Serialize(FArchive& Ar, UObject* Owner, int32 Idx)")]
        public ITransferible Move(Transfer transfer)
        {
            transfer.Move(ref StripFlags);
            if (StripFlags.IsDataStrippedForServer())
            {
                throw new NotImplementedException();
            }
            else
            {
                transfer.Move(ref Sections);

                if (!StripFlags.IsEditorDataStripped() && transfer.Supports.SkeletalMeshBuildRefactor)
                {
                    transfer.Move(ref UserSectionsData);
                }
                if (!transfer.Supports.SplitModelAndRenderData)
                {
                    transfer.Move(ref TempMultiSizeIndexContainer);
                }
                else if (!StripFlags.IsEditorDataStripped())
                {
                    transfer.Move(ref IndexBuffer);
                }
                transfer.Move(ref ActiveBoneIndices);
                if (!StripFlags.IsEditorDataStripped() && transfer.Supports.SkeletalMeshLODModelMeshInfo)
                {
                    transfer.Move(ref ImportedMeshInfos);
                }
            }
            if (!transfer.Supports.CombineSectionWithChunk)
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
                if (!transfer.Supports.RemoveSkeletalMeshLODModelBulkDatas)
                {
                    transfer.Move(ref RawPointIndices_DEPRECATED);
                }
                else
                {
                    transfer.Move(ref RawPointIndices2);
                }
                if (transfer.Supports.NewSkeletalMeshImporterWorkflow && !transfer.Supports.SkeletalMeshMoveEditorSourceDataToPrivateAsset)
                {
                    transfer.Move(ref RawSkeletalMeshBulkData_DEPRECATED);
                }
                if (transfer.Supports.SkeletalMeshMoveEditorSourceDataToPrivateAsset)
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
                if (!transfer.Supports.SplitModelAndRenderData)
                {
                    transfer.Move(ref DummyVertexBuffer);
                    if (transfer.Supports.UseSeparateSkinWeightBuffer)
                    {
                        transfer.Move(ref DummyWeightBuffer);
                    }
                    if (!StripFlags.IsClassDataStripped(1))
                    {
                        transfer.Move(ref TempMultiSizeAdjacencyIndexContainer);
                    }
                    if (transfer.Supports.VER_UE4_APEX_CLOTH && HasClothData())
                    {
                        transfer.Move(ref StripFlags2);
                        if (!StripFlags2.IsDataStrippedForServer())
                        {
                            transfer.Move(ref DummyClothData);
                            if (transfer.Supports.CompactClothVertexBuffer)
                            {
                                transfer.Move(ref DummyIndexMapping);
                            }
                        }
                    }
                }
            }
            if (transfer.Supports.SkinWeightProfiles)
            {
                transfer.Move(ref SkinWeightProfiles);
            }
            return this;
        }

        bool HasClothData()
        {
            for (int32 SectionIdx = 0; SectionIdx < Sections.Count; SectionIdx++)
            {
                if (Sections[SectionIdx].HasClothingData())
                {
                    return true;
                }
            }
            return false;
        }
    }

    public class FSkelMeshSection : Transferible<FSkelMeshSection>
    {
        public FStripDataFlags StripFlags;
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
        public FBoneIndexType[] BoneMap;
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
            transfer.Move(ref StripFlags);
            transfer.Move(ref MaterialIndex);
            if (!transfer.Supports.CombineSectionWithChunk)
                transfer.Move(ref DummyChunkIndex);
            if (!StripFlags.IsDataStrippedForServer())
                transfer.Move(ref BaseIndex);
            if (!StripFlags.IsDataStrippedForServer())
                transfer.Move(ref NumTriangles);
            if (!transfer.Supports.RemoveTriangleSorting)
                transfer.Move(ref DummyTriangleSorting);
            if (transfer.Supports.VER_UE4_APEX_CLOTH)
            {
                if (!transfer.Supports.DeprecateSectionDisabledFlag)
                    transfer.Move(ref bLegacyClothingSection_DEPRECATED);
                if (!transfer.Supports.RemoveDuplicatedClothingSections)
                    transfer.Move(ref CorrespondClothSectionIndex_DEPRECATED);
            }
            if (transfer.Supports.VER_UE4_APEX_CLOTH_LOD)
            {
                if (!transfer.Supports.RemoveEnableClothLOD)
                    transfer.Move(ref DummyEnableClothLOD);
            }
            if (transfer.Supports.RuntimeRecomputeTangent)
                transfer.Move(ref bRecomputeTangent);
            if (transfer.Supports.RecomputeTangentVertexColorMask)
                transfer.MoveEnum(ref RecomputeTangentsVertexMaskChannel);
            if (transfer.Supports.RefactorMeshEditorMaterials)
                transfer.Move(ref bCastShadow);
            if (transfer.Supports.SkelMeshSectionVisibleInRayTracingFlagAdded)
                transfer.Move(ref bVisibleInRayTracing);
            if (transfer.Supports.CombineSectionWithChunk)
            {
                if (!StripFlags.IsDataStrippedForServer())
                    transfer.Move(ref BaseVertexIndex);
                if (!StripFlags.IsEditorDataStripped())
                {
                    if (!transfer.Supports.CombineSoftAndRigidVerts)
                    {
                        transfer.Move(ref LegacyRigidVertices);
                    }
                    transfer.Move(ref SoftVertices);

                }
                if (transfer.Supports.IncreaseBoneIndexLimitPerChunk)
                    transfer.Move(ref bUse16BitBoneIndex);
                transfer.Move(ref BoneMap);
                if (transfer.Supports.SaveNumVertices)
                    transfer.Move(ref NumVertices);
                if (!transfer.Supports.CombineSoftAndRigidVerts)
                {
                    transfer.Move(ref DummyNumRigidVerts);
                    transfer.Move(ref DummyNumSoftVerts);
                }
                transfer.Move(ref MaxBoneInfluences);
                if (!transfer.Supports.AddClothMappingLODBias)
                {
                    transfer.Move(ref ClothMappingDataLODs, 1);
                }
                else
                {
                    transfer.Move(ref ClothMappingDataLODs);
                    //ClothMappingDataLODs ??= new();
                    //ClothMappingDataLODs.Resize(transfer);
                    //ClothMappingDataLODs.ForEach(list => transfer.Move(ref list));
                }
                if (!transfer.Supports.RemoveDuplicatedClothingSections)
                {
                    transfer.Move(ref DummyArray1);
                    transfer.Move(ref DummyArray2);
                }
                transfer.Move(ref CorrespondClothAssetIndex);
                if (!transfer.Supports.NewClothingSystemAdded)
                {
                    transfer.Move(ref DummyClothAssetSubmeshIndex);
                }
                else
                {
                    transfer.Move(ref ClothingData);
                }
                if (transfer.Supports.DetectOVerlappingVertices)
                {
                    transfer.Move(ref OverlappingVertices);
                }
                if (transfer.Supports.AddSkeletalMeshSectionDisable)
                    transfer.Move(ref bDisabled);
                if (transfer.Supports.SectionIgnoreByReduceAdded)
                    transfer.Move(ref GenerateUpToLodIndex);
                if (transfer.Supports.SkeletalMeshBuildRefactor)
                {
                    transfer.Move(ref OriginalDataSectionIndex);
                    transfer.Move(ref ChunkedParentSectionIndex);
                }
            }
            return this;
        }

        public bool HasClothingData()
        {
            return ClothMappingDataLODs?.Count > 0 && ClothMappingDataLODs[0].Count > 0;
        }
    }

    public class FLegacyRigidSkinVertex : ITransferible
    {
        public FVector3f Position;
        public FVector3f TangentX;
        public FVector3f TangentY;
        public FVector3f TangentZ;
        public FDeprecatedSerializedPackedNormal TempTangentX;
        public FDeprecatedSerializedPackedNormal TempTangentY;
        public FDeprecatedSerializedPackedNormal TempTangentZ;
        public FVector2f[] UVs = new FVector2f[Consts.MAX_TEXCOORDS] { new(), new(), new(), new() };
        public FColor Color;
        public byte Bone;

        [Location("operator<<(FArchive& Ar, FLegacyRigidSkinVertex& V)")]
        public ITransferible Move(Transfer transfer)
        {
            transfer.Move(ref Position);
            if (!transfer.Supports.IncreaseNormalPrecision)
            {
                transfer.Move(ref TempTangentX);
                transfer.Move(ref TempTangentY);
                transfer.Move(ref TempTangentZ);
            }
            else
            {
                transfer.Move(ref TangentX);
                transfer.Move(ref TangentY);
                transfer.Move(ref TangentZ);
            }
            for (int UVIdx = 0; UVIdx < Consts.MAX_TEXCOORDS; ++UVIdx)
            {
                transfer.Move(ref UVs[UVIdx]);
            }
            transfer.Move(ref Color);
            transfer.Move(ref Bone);
            return this;
        }
    }

    public class FSoftSkinVertex : ITransferible
    {
        public FVector3f Position;
        public FVector3f TangentX;
        public FVector3f TangentY;
        public FVector4f TangentZ;
        public FDeprecatedSerializedPackedNormal TempTangentX;
        public FDeprecatedSerializedPackedNormal TempTangentY;
        public FDeprecatedSerializedPackedNormal TempTangentZ;
        public FVector2f[] UVs = new FVector2f[Consts.MAX_TEXCOORDS];
        public FColor Color;
        public FBoneIndexType[] InfluenceBones = new FBoneIndexType[Consts.MAX_TOTAL_INFLUENCES];
        public UInt16[] InfluenceWeights = new UInt16[Consts.MAX_TOTAL_INFLUENCES];
        public TUInt8[] OldInfluence = new TUInt8[Consts.MAX_TOTAL_INFLUENCES];

        [Location("operator<<(FArchive& Ar, FSoftSkinVertex& V)")]
        public ITransferible Move(Transfer transfer)
        {
            transfer.Move(ref Position);
            if (!transfer.Supports.IncreaseNormalPrecision)
            {
                transfer.Move(ref TempTangentX);
                transfer.Move(ref TempTangentY);
                transfer.Move(ref TempTangentZ);
            }
            else
            {
                transfer.Move(ref TangentX);
                transfer.Move(ref TangentY);
                transfer.Move(ref TangentZ);
            }
            for (int UVIdx = 0; UVIdx < Consts.MAX_TEXCOORDS; ++UVIdx)
            {
                transfer.Move(ref UVs[UVIdx]);
            }
            transfer.Move(ref Color);
            bool bBeforeIncreaseBoneIndexLimitPerChunk = !transfer.Supports.IncreaseBoneIndexLimitPerChunk;

            for (int i = 0; i < Consts.MAX_INFLUENCES_PER_STREAM; i++)
            {
                if (bBeforeIncreaseBoneIndexLimitPerChunk)
                    transfer.Move((byte)0);
                else
                    transfer.Move(ref InfluenceBones[i]);
            }
            if (transfer.Supports.VER_UE4_SUPPORT_8_BONE_INFLUENCES_SKELETAL_MESHES)
            {
                for (int i = Consts.MAX_INFLUENCES_PER_STREAM; i < Consts.EXTRA_BONE_INFLUENCES; i++)
                {
                    if (bBeforeIncreaseBoneIndexLimitPerChunk)
                        transfer.Move((byte)0);
                    else
                        transfer.Move(ref InfluenceBones[i]);
                }
            }
            if (transfer.Supports.UnlimitedBoneInfluences)
            {
                for (int i = Consts.EXTRA_BONE_INFLUENCES; i < Consts.MAX_TOTAL_INFLUENCES; i++)
                    transfer.Move(ref InfluenceBones[i]);
            }
            if (transfer.Supports.IncreasedSkinWeightPrecision)
            {
                for (int i = 0; i < Consts.MAX_TOTAL_INFLUENCES; i++)
                {
                    transfer.Move(ref InfluenceWeights[i]);
                }
            }
            else
            {
                int MaxInfluences = Consts.MAX_INFLUENCES_PER_STREAM;
                if (transfer.Supports.UnlimitedBoneInfluences)
                    MaxInfluences = Consts.MAX_TOTAL_INFLUENCES;
                else if (transfer.Supports.VER_UE4_SUPPORT_8_BONE_INFLUENCES_SKELETAL_MESHES)
                    MaxInfluences = Consts.EXTRA_BONE_INFLUENCES;

                for (int i = 0; i < MaxInfluences; i++)
                    transfer.Move(ref OldInfluence[i]);
            }
            return this;
        }
    }

    public class FSoftSkinVertexListJsonConverter : JsonConverter<List<FSoftSkinVertex>>
    {
        public Transfer transfer;

        public FSoftSkinVertexListJsonConverter SetTransfer(Transfer transfer)
        {
            this.transfer = transfer;
            return this;
        }

        public override List<FSoftSkinVertex> Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            List<FSoftSkinVertex> list = [];
            if (reader.TokenType == JsonTokenType.StartArray)
            {
                if (reader.Read() && reader.TokenType != JsonTokenType.EndArray)
                {
                    _ = reader.GetString();
                }
                while (reader.Read() && reader.TokenType != JsonTokenType.EndArray)
                {
                    FSoftSkinVertex item = new();
                    string s = reader.GetString();

                    (int a, int b) = (s.IndexOf('(') + 1, s.IndexOf(')'));
                    float[] v = s.Substring(a, b - a).ToFloatArray();
                    item.Position = new FVector3f { X = v[0], Y = v[1], Z = v[2] };

                    (a, b) = (s.IndexOf('(', b + 1) + 1, s.IndexOf(')', b + 1));
                    v = s.Substring(a, b - a).ToFloatArray();
                    item.TangentX = v.Length == 3 ? new FVector3f { X = v[0], Y = v[1], Z = v[2] } : default;
                    item.TempTangentX = v.Length == 1 ? new FDeprecatedSerializedPackedNormal { Packed = (uint)v[0] } : default;

                    (a, b) = (s.IndexOf('(', b + 1) + 1, s.IndexOf(')', b + 1));
                    v = s.Substring(a, b - a).ToFloatArray();
                    item.TangentY = v.Length == 3 ? new FVector3f { X = v[0], Y = v[1], Z = v[2] } : default;
                    item.TempTangentY = v.Length == 1 ? new FDeprecatedSerializedPackedNormal { Packed = (uint)v[0] } : default;

                    (a, b) = (s.IndexOf('(', b + 1) + 1, s.IndexOf(')', b + 1));
                    v = s.Substring(a, b - a).ToFloatArray();
                    item.TangentZ = v.Length == 4 ? new FVector4f { X = v[0], Y = v[1], Z = v[2], W = v[3] } : default;
                    item.TempTangentZ = v.Length == 1 ? new FDeprecatedSerializedPackedNormal { Packed = (uint)v[0] } : default;

                    (a, b) = (s.IndexOf('(', b + 1) + 1, s.IndexOf(')', b + 1));
                    v = s.Substring(a, b - a).Replace(" | ", " ").ToFloatArray();
                    item.UVs[0] = new FVector2f { X = v[0], Y = v[1] };
                    item.UVs[1] = new FVector2f { X = v[2], Y = v[3] };
                    item.UVs[2] = new FVector2f { X = v[4], Y = v[5] };
                    item.UVs[3] = new FVector2f { X = v[6], Y = v[7] };

                    (a, b) = (s.IndexOf('(', b + 1) + 1, s.IndexOf(')', b + 1));
                    byte[] bytes = s.Substring(a, b - a).ToByteArray();
                    item.Color = new FColor { R = bytes[0], G = bytes[1], B = bytes[2], A = bytes[3] };

                    (a, b) = (s.IndexOf('(', b + 1) + 1, s.IndexOf(')', b + 1));
                    item.InfluenceBones = s.Substring(a, b - a).ToUInt16Array();

                    (a, b) = (s.IndexOf('(', b + 1) + 1, s.IndexOf(')', b + 1));
                    item.InfluenceWeights = s.Substring(a, b - a).ToUInt16Array();

                    (a, b) = (s.IndexOf('(', b + 1) + 1, s.IndexOf(')', b + 1));
                    item.OldInfluence = s.Substring(a, b - a).Split(' ').Select(x => new TUInt8 { Value = byte.Parse(x) }).ToArray();

                    list.Add(item);
                }
            }
            return list;
        }

        public override void Write(Utf8JsonWriter writer, List<FSoftSkinVertex> value, JsonSerializerOptions options)
        {
            Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;
            writer.WriteStartArray();

            if (value.Count > 0 && transfer.Supports.IncreaseNormalPrecision)
            {
                writer.WriteStringValue("(Position) (TangentX) (TangentY) (TangentZ) (UVs) (Color) (InfluenceBones) (InfluenceWeights) (OldInfluence)");
            }
            else
            {
                writer.WriteStringValue("(Position) (TempTangentX) (TempTangentY) (TempTangentZ) (UVs) (Color) (InfluenceBones) (InfluenceWeights) (OldInfluence)");
            }
            foreach (var v in value)
            {
                StringBuilder s = new StringBuilder();
                s.Append($"({v.Position.X} {v.Position.Y} {v.Position.Z}) ");
                if (transfer.Supports.IncreaseNormalPrecision)
                {
                    s.Append($"({v.TangentX.X} {v.TangentX.Y} {v.TangentX.Z}) ");
                    s.Append($"({v.TangentY.X} {v.TangentY.Y} {v.TangentY.Z}) ");
                    s.Append($"({v.TangentZ.X} {v.TangentZ.Y} {v.TangentZ.Z} {v.TangentZ.W}) ");
                }
                else
                {
                    s.Append($"({v.TempTangentX.Packed}) ");
                    s.Append($"({v.TempTangentY.Packed}) ");
                    s.Append($"({v.TempTangentZ.Packed}) ");
                }
                s.Append($"({v.UVs[0].X} {v.UVs[0].Y} | {v.UVs[1].X} {v.UVs[1].Y} | {v.UVs[2].X} {v.UVs[2].Y} | {v.UVs[3].X} {v.UVs[3].Y}) ");
                s.Append($"({v.Color.R} {v.Color.G} {v.Color.B} {v.Color.A}) ");
                s.Append($"({string.Join(' ', v.InfluenceBones)}) ");
                s.Append($"({string.Join(' ', v.InfluenceWeights)}) ");
                s.Append($"({string.Join(' ', v.OldInfluence)})");
                writer.WriteStringValue(s.ToString());
            }

            writer.WriteEndArray();
        }
    }

    public class FSkelMeshSourceSectionUserData : ITransferible
    {
        public FStripDataFlags StripFlags;
        public FBool bRecomputeTangent;
        public ESkinVertexColorChannel RecomputeTangentsVertexMaskChannel;
        public FBool bCastShadow;
        public FBool bVisibleInRayTracing;
        public Int16 CorrespondClothAssetIndex;
        public FClothingSectionData ClothingData;
        public FBool bDisabled;
        public Int32 GenerateUpToLodIndex;

        public ITransferible Move(Transfer transfer)
        {
            transfer.Move(ref StripFlags);
            transfer.Move(ref bRecomputeTangent);
            if (transfer.Supports.RecomputeTangentVertexColorMask)
            {
                transfer.MoveEnum(ref RecomputeTangentsVertexMaskChannel);
            }
            transfer.Move(ref bCastShadow);
            if (transfer.Supports.SkelMeshSectionVisibleInRayTracingFlagAdded)
            {
                transfer.Move(ref bVisibleInRayTracing);
            }
            transfer.Move(ref bDisabled);
            transfer.Move(ref GenerateUpToLodIndex);
            transfer.Move(ref CorrespondClothAssetIndex);
            transfer.Move(ref ClothingData);
            return this;
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
        public FStripDataFlags StripFlags;
        public UInt32 BaseVertexIndex;
        public List<FLegacyRigidSkinVertex> LegacyRigidVertices;
        public List<FSoftSkinVertex> SoftVertices;
        public FBoneIndexType[] BoneMap;
        public Int32 DummyNumRigidVerts;
        public Int32 DummyNumSoftVerts;
        public List<FMeshToMeshVertData> ApexClothMappingData;
        public List<FVector> PhysicalMeshVertices;
        public List<FVector> PhysicalMeshNormals;
        public Int32 MaxBoneInfluences;
        public Int16 CorrespondClothAssetIndex;
        public Int16 ClothAssetSubmeshIndex;

        [Location("friend FArchive& operator<<(FArchive& Ar, FLegacySkelMeshChunk& C)")]
        public ITransferible Move(Transfer transfer)
        {
            transfer.Move(ref StripFlags);
            if (!StripFlags.IsDataStrippedForServer())
            {
                transfer.Move(ref BaseVertexIndex);
            }
            if (!StripFlags.IsEditorDataStripped())
            {
                if (!transfer.Supports.CombineSoftAndRigidVerts)
                {
                    transfer.Move(ref LegacyRigidVertices);
                }
                transfer.Move(ref SoftVertices);
            }
            transfer.Move(ref BoneMap);
            if (!transfer.Supports.CombineSoftAndRigidVerts)
            {
                transfer.Move(ref DummyNumRigidVerts);
                transfer.Move(ref DummyNumSoftVerts);
            }
            transfer.Move(ref MaxBoneInfluences);
            if (transfer.Supports.VER_UE4_APEX_CLOTH)
            {
                transfer.Move(ref ApexClothMappingData);
                transfer.Move(ref PhysicalMeshVertices);
                transfer.Move(ref PhysicalMeshNormals);
                transfer.Move(ref CorrespondClothAssetIndex);
                transfer.Move(ref ClothAssetSubmeshIndex);
            }
            return this;
        }
    }
}
