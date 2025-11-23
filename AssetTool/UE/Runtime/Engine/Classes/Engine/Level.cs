namespace AssetTool
{
    [JsonAsset("Level")]
    public class ULevel : UObject
    {
        public TTransArray<TUInt32> OldActors;
        public List<FObjectPtr> Actors;
        public FURL URL;
        public FObjectPtr Model;
        public List<FObjectPtr> ModelComponents;
        public FObjectPtr LevelScriptBlueprint;
        public FObjectPtr LevelScriptActor;
        public Dictionary<TUInt32, List<FStreamableTextureInstance>> Dummy0;
        public Dictionary<TUInt32, List<FDynamicTextureInstance>> Dummy1;
        public bool Dummy2;
        public uint32 Size;
        public UInt32 DummySetup;
        public Dictionary<TUInt32, TBool> Dummy3;
        public FObjectPtr NavListStart;
        public FObjectPtr NavListEnd;
        public FPrecomputedLightVolumeData LegacyData;
        public FPrecomputedVisibilityHandler PrecomputedVisibilityHandler;
        public FPrecomputedVolumeDistanceField PrecomputedVolumeDistanceField;
        public FWorldTileInfo Info;
        public Dictionary<FGuid, FObjectPtr> ActorFolders;
        public bool bUseActorFolders;
        public bool bUseExternalActors;

        public ULevel()
        {
            ArrayMovers.Add("StaticNavigableGeometry", (transfer, value) => value.ToObject<FVector>(transfer).Move(transfer));
        }

        [Location("void ULevel::Serialize( FArchive& Ar )")]
        public override ITransferable Move(Transfer transfer)
        {
            base.Move(transfer);

            if (Members.FirstOrDefault(x => x.Key.Contains("bUseActorFolders")) is var value && value.Value is { })
            {
                bUseActorFolders = Convert.ToBoolean(value.Value.ToString());
            }
            if (Members.FirstOrDefault(x => x.Key.Contains("bUseExternalActors")) is var value2 && value2.Value is { })
            {
                bUseExternalActors = Convert.ToBoolean(value2.Value.ToString());
            }

            if (!transfer.Supports.LevelTransArrayConvertedToTArray)
                transfer.Move(ref OldActors);
            else
                transfer.Move(ref Actors);
            transfer.Move(ref URL);
            transfer.Move(ref Model);
            transfer.Move(ref ModelComponents);
            if (!transfer.GlobalObjects.IsFilterEditorOnly() || !transfer.Supports.VER_UE4_EDITORONLY_BLUEPRINTS)
            {
                transfer.Move(ref LevelScriptBlueprint);
            }
            transfer.Move(ref LevelScriptActor);
            if (!transfer.Supports.RemovedTextureStreamingLevelData)
            {
                transfer.Move(ref Dummy0);
                transfer.Move(ref Dummy1);
                transfer.Move(ref Dummy2);
                transfer.Move(ref Size);
                if (!transfer.Supports.VER_UE4_REMOVE_LEVELBODYSETUP)
                {
                    transfer.Move(ref DummySetup);
                }
                transfer.Move(ref Dummy3);
            }
            transfer.Move(ref NavListStart);
            transfer.Move(ref NavListEnd);

            if (!transfer.Supports.MapBuildDataSeparatePackage)
            {
                transfer.Move(ref LegacyData);
            }
            transfer.Move(ref PrecomputedVisibilityHandler);
            transfer.Move(ref PrecomputedVolumeDistanceField);
            if (transfer.Supports.VER_UE4_WORLD_LEVEL_INFO && !transfer.Supports.VER_UE4_WORLD_LEVEL_INFO_UPDATED)
            {
                transfer.Move(ref Info);
            }
            if (transfer.Supports.AddLevelActorFolders)
            {
                if (bUseActorFolders)
                {
                    if (!bUseExternalActors)
                    {
                        transfer.Move(ref ActorFolders);
                    }
                }
            }
            return this;
        }
    }

    public class FStreamableTextureInstance : ITransferable
    {
        public FBoxSphereBounds Bounds;
        public FSphere BoundingSphere;
        public float MinDistance;
        public float MaxDistance;
        public float TexelFactor;

        [Location("FArchive& operator<<( FArchive& Ar, FStreamableTextureInstance& TextureInstance )")]
        public virtual ITransferable Move(Transfer transfer)
        {
            if (transfer.Supports.VER_UE4_STREAMABLE_TEXTURE_AABB)
                transfer.Move(ref Bounds);
            else
                transfer.Move(ref BoundingSphere);

            if (transfer.Supports.VER_UE4_STREAMABLE_TEXTURE_MIN_MAX_DISTANCE)
            {
                transfer.Move(ref MinDistance);
                transfer.Move(ref MaxDistance);
            }

            transfer.Move(ref TexelFactor);
            return this;
        }
    }

    public class FDynamicTextureInstance : FStreamableTextureInstance
    {
        public FObjectPtr Texture;
        public bool bAttached;
        public float OriginalRadius;

        [Location("FArchive& operator<<( FArchive& Ar, FDynamicTextureInstance& TextureInstance )")]
        public override ITransferable Move(Transfer transfer)
        {
            base.Move(transfer);
            transfer.Move(ref Texture);
            transfer.Move(ref bAttached);
            transfer.Move(ref OriginalRadius);
            return this;
        }
    }

    public class FPrecomputedVisibilityHandler : ITransferable
    {
        public FVector2D PrecomputedVisibilityCellBucketOriginXY;
        public float PrecomputedVisibilityCellSizeXY;
        public float PrecomputedVisibilityCellSizeZ;
        public int32 PrecomputedVisibilityCellBucketSizeXY;
        public int32 PrecomputedVisibilityNumCellBuckets;
        public List<FPrecomputedVisibilityBucket> PrecomputedVisibilityCellBuckets;

        [Location("FArchive& operator<<( FArchive& Ar, FPrecomputedVisibilityHandler& D )")]
        public ITransferable Move(Transfer transfer)
        {
            transfer.Move(ref PrecomputedVisibilityCellBucketOriginXY);
            transfer.Move(ref PrecomputedVisibilityCellSizeXY);
            transfer.Move(ref PrecomputedVisibilityCellSizeZ);
            transfer.Move(ref PrecomputedVisibilityCellBucketSizeXY);
            transfer.Move(ref PrecomputedVisibilityNumCellBuckets);
            transfer.Move(ref PrecomputedVisibilityCellBuckets);
            return this;
        }
    }

    public class FPrecomputedVolumeDistanceField : ITransferable
    {
        public float VolumeMaxDistance;
        public FBox VolumeBox;
        public int32 VolumeSizeX;
        public int32 VolumeSizeY;
        public int32 VolumeSizeZ;
        public List<FColor> Data;

        [Location("FArchive& operator<<( FArchive& Ar, FPrecomputedVolumeDistanceField& D )")]
        public ITransferable Move(Transfer transfer)
        {
            transfer.Move(ref VolumeMaxDistance);
            transfer.Move(ref VolumeBox);
            transfer.Move(ref VolumeSizeX);
            transfer.Move(ref VolumeSizeY);
            transfer.Move(ref VolumeSizeZ);
            transfer.Move(ref Data);
            return this;
        }
    }

    public class FPrecomputedVisibilityBucket : ITransferable
    {
        public int32 CellDataSize;
        public List<FPrecomputedVisibilityCell> Cells;
        public List<FCompressedVisibilityChunk> CellDataChunks;

        [Location("friend FArchive& operator<<( FArchive& Ar, FPrecomputedVisibilityBucket& D )")]
        public ITransferable Move(Transfer transfer)
        {
            transfer.Move(ref CellDataSize);
            transfer.Move(ref Cells);
            transfer.Move(ref CellDataChunks);
            return this;
        }
    }

    public class FPrecomputedVisibilityCell : ITransferable
    {
        public FVector Min;
        public uint16 ChunkIndex;
        public uint16 DataOffset;

        [Location("friend FArchive& operator<<( FArchive& Ar, FPrecomputedVisibilityCell& D )")]
        public ITransferable Move(Transfer transfer)
        {
            transfer.Move(ref Min);
            transfer.Move(ref ChunkIndex);
            transfer.Move(ref DataOffset);
            return this;
        }
    }

    public class FCompressedVisibilityChunk : ITransferable
    {
        public bool bCompressed;
        public int32 UncompressedSize;
        public uint8[] Data;

        [Location("friend FArchive& operator<<( FArchive& Ar, FCompressedVisibilityChunk& D )")]
        public ITransferable Move(Transfer transfer)
        {
            transfer.Move(ref bCompressed);
            transfer.Move(ref UncompressedSize);
            transfer.Move(ref Data);
            return this;
        }
    }
}