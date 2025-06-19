namespace AssetTool
{
    public class FMeshMapBuildData : ITransferible
    {
        public FLightMap LightMap;
        public FShadowMap ShadowMap;
        public List<FGuid> IrrelevantLights;
        public TBulkList<FPerInstanceLightmapData> PerInstanceLightmapData;

        [Location("FArchive& operator<<(FArchive& Ar, FMeshMapBuildData& MeshMapBuildData)")]
        public ITransferible Move2(Transfer transfer)
        {
            transfer.Move(ref LightMap);
            transfer.Move(ref ShadowMap);
            transfer.Move(ref IrrelevantLights);
            transfer.Move(ref PerInstanceLightmapData);
            return this;
        }

        public ITransferible MoveValue(Transfer transfer)
        {
            transfer.Move(ref LightMap);
            transfer.Move(ref ShadowMap);
            return this;
        }
    }

    public class FPerInstanceLightmapData : ITransferible
    {
        public FVector2f LightmapUVBias;
        public FVector2f ShadowmapUVBias;

        public ITransferible Move2(Transfer transfer)
        {
            transfer.Move(ref LightmapUVBias);
            transfer.Move(ref ShadowmapUVBias);
            return this;
        }
    }

    [JsonAsset("MapBuildDataRegistry")]
    public class UMapBuildDataRegistry : UObject
    {
        public FStripDataFlags StripFlags;
        public Dictionary<FGuid, FMeshMapBuildData> MeshBuildData;
        public Dictionary<FGuid, FPrecomputedLightVolumeData> LevelPrecomputedLightVolumeBuildData;
        public Dictionary<FGuid, FPrecomputedVolumetricLightmapData> LevelPrecomputedVolumetricLightmapBuildData;
        public Dictionary<FGuid, FLightComponentMapBuildData> LightBuildData;
        public Dictionary<FGuid, FReflectionCaptureMapBuildData> ReflectionCaptureBuildData;
        public Dictionary<FGuid, FSkyAtmosphereMapBuildData> SkyAtmosphereBuildData;

        [Location("void UMapBuildDataRegistry::Serialize(FArchive& Ar)")]
        public override UObject Move(Transfer transfer)
        {
            base.Move(transfer);
            transfer.Move(ref StripFlags);
            if (!StripFlags.IsDataStrippedForServer())
            {
                transfer.Move(ref MeshBuildData);
                transfer.Move(ref LevelPrecomputedLightVolumeBuildData);
                if (transfer.Supports.VolumetricLightmaps)
                {
                    transfer.Move(ref LevelPrecomputedVolumetricLightmapBuildData);
                }
                transfer.Move(ref LightBuildData);
                if (transfer.Supports.MoveReflectionCaptureDataToMapBuildData)
                {
                    transfer.Move(ref ReflectionCaptureBuildData);
                }
                if (transfer.Supports.SkyAtmosphereStaticLightingVersioning)
                {
                    transfer.Move(ref SkyAtmosphereBuildData);
                }
            }
            return this;
        }

        public class FLightComponentMapBuildData : ITransferible
        {
            public Int32 ShadowMapChannel;
            public FStaticShadowDepthMapData DepthMap;

            [Location("FArchive& operator<<(FArchive& Ar, FLightComponentMapBuildData& LightBuildData)")]
            public ITransferible Move2(Transfer transfer)
            {
                transfer.Move(ref ShadowMapChannel);
                transfer.Move(ref DepthMap);
                return this;
            }
        }

        public class FReflectionCaptureMapBuildData : FReflectionCaptureData, ITransferible
        {
            public Int32 CubemapSize;
            public float AverageBrightness;
            public float Brightness;
            public Ptr EncodedCaptureData = new Ptr("UTextureCube");
            public byte[] EncodedHDRCapturedData;
            public byte[] StrippedData;

            [Location("FArchive& operator<<(FArchive& Ar, FReflectionCaptureMapBuildData& ReflectionCaptureMapBuildData)")]
            public ITransferible Move2(Transfer transfer)
            {
                transfer.Move(ref CubemapSize);
                transfer.Move(ref AverageBrightness);
                if (transfer.Supports.StoreReflectionCaptureBrightnessForCooking && !transfer.Supports.ExcludeBrightnessFromEncodedHDRCubemap)
                {
                    transfer.Move(ref Brightness);
                }
                transfer.Move(ref FullHDRCapturedData);
                if (transfer.Supports.StoreReflectionCaptureCompressedMobile && !transfer.Supports.StoreReflectionCaptureEncodedHDRDataInRG11B10Format)
                {
                    transfer.Move(ref EncodedCaptureData);
                }
                else
                {
                    if (transfer.Supports.StoreReflectionCaptureEncodedHDRDataInRG11B10Format)
                    {
                        transfer.Move(ref EncodedHDRCapturedData);
                    }
                    else
                    {
                        transfer.Move(ref StrippedData);
                    }
                }
                return this;
            }
        }

        public class FReflectionCaptureData
        {
            public byte[] FullHDRCapturedData;
        }

        public class FSkyAtmosphereMapBuildData : ITransferible
        {
            [Location("FArchive& operator<<(FArchive& Ar, FSkyAtmosphereMapBuildData& Data)")]
            public ITransferible Move2(Transfer transfer)
            {
                return this;
            }
        }
    }
}
