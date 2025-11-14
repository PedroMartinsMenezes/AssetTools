namespace AssetTool
{
    [JsonAsset("Model")]
    public class UModel : UObject
    {
        public FStripDataFlags StripFlags;
        public FBoxSphereBounds Bounds;
        public TBulkList<FVector3f> OldVectors;
        public TBulkList<FVector3f> OldPoints;
        public TBulkList<FBspNode> OldNodes;
        public TBulkList<FVector3f> Vectors;
        public TBulkList<FVector3f> Points;
        public TBulkList<FBspNode> Nodes;
        public TTransArray<FBspSurf> OldSurfs;
        public FBspSurf[] Surfs;
        public TBulkList<FVert> Verts;
        public TBulkList<FVert> OldVerts;
        public int32 NumSharedSides;
        public int32 NumZones;
        public FZoneProperties[] DummyZones;
        public UInt32 Polys;
        public TBulkList<TInt32> LeafHulls;
        public TBulkList<FLeaf> Leaves;
        public UInt32 DummyPolys;
        public TBulkList<TInt32> DummyLeafHulls;
        public TBulkList<FLeaf> DummyLeaves;
        public FBool RootOutside;
        public FBool Linked;
        public TBulkList<TInt32> DummyPortalNodes;
        public uint32 NumUniqueVertices;
        public FModelVertexBuffer VertexBuffer;
        public FGuid LightingGuid;
        public FLightmassPrimitiveSettings[] LightmassSettings;

        [Location("void UModel::Serialize( FArchive& Ar )")]
        public override ITransferable Move(Transfer transfer)
        {
            base.Move(transfer);
            transfer.Move(ref StripFlags);
            transfer.Move(ref Bounds);
            if (!transfer.Supports.VER_UE4_BSP_UNDO_FIX)
            {
                transfer.Move(ref OldVectors);
                transfer.Move(ref OldPoints);
                transfer.Move(ref OldNodes);
            }
            else
            {
                transfer.Move(ref Vectors);
                transfer.Move(ref Points);
                transfer.Move(ref Nodes);
            }
            if (!transfer.Supports.VER_UE4_BSP_UNDO_FIX)
            {
                transfer.Move(ref OldSurfs);
                transfer.Move(ref OldVerts);
            }
            else
            {
                transfer.Move(ref Surfs);
                transfer.Move(ref Verts);
            }
            if (!transfer.Supports.VER_UE4_REMOVE_ZONES_FROM_MODEL)
            {
                transfer.Move(ref NumSharedSides);
                transfer.Move(ref NumZones);
                transfer.Move(ref DummyZones, NumZones);
            }
            else
            {
                transfer.Move(ref NumSharedSides);
            }
            bool bHasEditorOnlyData = !transfer.GlobalObjects.IsFilterEditorOnly() || !transfer.Supports.VER_UE4_REMOVE_UNUSED_UPOLYS_FROM_UMODEL;

            if (bHasEditorOnlyData)
            {
                transfer.Move(ref Polys);
                transfer.Move(ref LeafHulls);
                transfer.Move(ref Leaves);
            }
            transfer.Move(ref RootOutside);
            transfer.Move(ref Linked);
            if (!transfer.Supports.VER_UE4_REMOVE_ZONES_FROM_MODEL)
            {
                transfer.Move(ref DummyPortalNodes);
            }
            transfer.Move(ref NumUniqueVertices);
            if (!StripFlags.IsEditorDataStripped() || !StripFlags.IsClassDataStripped(1))
            {
                transfer.Move(ref VertexBuffer);
            }
            transfer.Move(ref LightingGuid);
            transfer.Move(ref LightmassSettings);
            return this;
        }
    }

    public struct FBspNode : ITransferable
    {
        public const int MAX_ZONES = 64;

        public FPlane4f Plane;
        public int32 iVertPool;
        public int32 iSurf;
        public int32 iVertexIndex;
        public uint16 ComponentIndex;
        public uint16 ComponentNodeIndex;
        public int32 ComponentElementIndex;
        public int32 iBack;
        public int32 iFront;
        public int32 iPlane;
        public int32 iCollisionBound;
        public uint8 iZone0;
        public uint8 iZone1;
        public uint8 NumVertices;
        public uint8 NodeFlags;
        public int32 iLeaf0;
        public int32 iLeaf1;


        [Location("FArchive& operator<<( FArchive& Ar, FBspNode& N )")]
        public ITransferable Move(Transfer transfer)
        {
            transfer.Move(ref Plane);
            transfer.Move(ref iVertPool);
            transfer.Move(ref iSurf);
            transfer.Move(ref iVertexIndex);
            transfer.Move(ref ComponentIndex);
            transfer.Move(ref ComponentNodeIndex);
            transfer.Move(ref ComponentElementIndex);
            transfer.Move(ref iBack);
            transfer.Move(ref iFront);
            transfer.Move(ref iPlane);
            transfer.Move(ref iCollisionBound);
            transfer.Move(ref iZone0);
            transfer.Move(ref iZone1);
            transfer.Move(ref NumVertices);
            transfer.Move(ref NodeFlags);
            transfer.Move(ref iLeaf0);
            transfer.Move(ref iLeaf1);
            return this;
        }
    }

    public struct FBspSurf : ITransferable
    {
        public UInt32 Material;
        public uint32 PolyFlags;
        public int32 pBase;
        public int32 vNormal;
        public int32 vTextureU;
        public int32 vTextureV;
        public int32 iBrushPoly;
        public UInt32 Actor;
        public FPlane4f Plane;
        public float LightMapScale;
        public int32 iLightmassIndex;
        public bool bHiddenEdTemporary;
        public bool bHiddenEdLevel;
        public bool bHiddenEdLayer;

        public ITransferable Move(Transfer transfer)
        {
            transfer.Move(ref Material);
            transfer.Move(ref PolyFlags);
            transfer.Move(ref pBase);
            transfer.Move(ref vNormal);
            transfer.Move(ref vTextureU);
            transfer.Move(ref vTextureV);
            transfer.Move(ref iBrushPoly);
            transfer.Move(ref Actor);
            transfer.Move(ref Plane);
            transfer.Move(ref LightMapScale);
            transfer.Move(ref iLightmassIndex);
            return this;
        }
    }

    public struct FVert : ITransferable
    {
        public int32 pVertex;
        public int32 iSide;
        public FVector2f ShadowTexCoord;
        public FVector2f BackfaceShadowTexCoord;

        public ITransferable Move(Transfer transfer)
        {
            transfer.Move(ref pVertex);
            transfer.Move(ref iSide);
            transfer.Move(ref ShadowTexCoord);
            transfer.Move(ref BackfaceShadowTexCoord);
            return this;
        }
    }

    public struct FZoneProperties : ITransferable
    {
        public UInt32 ZoneActor;
        public FZoneSet Connectivity;
        public FZoneSet Visibility;
        public float LastRenderTime;

        public ITransferable Move(Transfer transfer)
        {
            transfer.Move(ref ZoneActor);
            transfer.Move(ref Connectivity);
            transfer.Move(ref Visibility);
            transfer.Move(ref LastRenderTime);
            return this;
        }
    }

    public struct FZoneSet : ITransferable
    {
        public uint64 MaskBits;

        public ITransferable Move(Transfer transfer)
        {
            transfer.Move(ref MaskBits);
            return this;
        }
    }

    public struct FLeaf : ITransferable
    {
        public int32 iZone;

        public ITransferable Move(Transfer transfer)
        {
            transfer.Move(ref iZone);
            return this;
        }
    }

    public struct FModelVertexBuffer : ITransferable
    {
        public TBulkList<FDepecatedModelVertex> DepricatedVertices;
        public List<FModelVertex> Vertices;

        [Location("FArchive& operator<<(FArchive& Ar,FModelVertexBuffer& B)")]
        public ITransferable Move(Transfer transfer)
        {
            if (!transfer.Supports.ModelVertexBufferSerialization || !transfer.Supports.IncreaseNormalPrecision)
            {
                transfer.Move(ref DepricatedVertices);
            }
            else
            {
                transfer.Move(ref Vertices);
            }
            return this;
        }
    }

    public struct FDepecatedModelVertex : ITransferable
    {
        public FVector3f Position;
        public FDeprecatedSerializedPackedNormal TangentX;
        public FDeprecatedSerializedPackedNormal TangentZ;
        public FVector2f TexCoord;
        public FVector2f ShadowTexCoord;

        public ITransferable Move(Transfer transfer)
        {
            transfer.Move(ref Position);
            transfer.Move(ref TangentX);
            transfer.Move(ref TangentZ);
            transfer.Move(ref TexCoord);
            transfer.Move(ref ShadowTexCoord);
            return this;
        }
    }

    public struct FModelVertex : ITransferable
    {
        public FVector3f Position;
        public FVector3f TangentX;
        public FVector4f TangentZ;
        public FVector2f TexCoord;
        public FVector2f ShadowTexCoord;
        public FDeprecatedSerializedPackedNormal TempTangentX;
        public FDeprecatedSerializedPackedNormal TempTangentZ;

        [Location("FArchive& operator<<(FArchive& Ar,FModelVertex& V)")]
        public ITransferable Move(Transfer transfer)
        {
            transfer.Move(ref Position);
            if (!transfer.Supports.IncreaseNormalPrecision)
            {
                transfer.Move(ref TempTangentX);
                transfer.Move(ref TempTangentZ);
            }
            else
            {
                transfer.Move(ref TangentX);
                transfer.Move(ref TangentZ);
            }
            transfer.Move(ref TexCoord);
            transfer.Move(ref ShadowTexCoord);
            return this;
        }
    }
}