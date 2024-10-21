namespace AssetTool
{
    public class FMeshMapBuildData : ITransferible
    {
        public UInt32 LightMap;
        public UInt32 ShadowMap;
        public List<FGuid> IrrelevantLights;
        public List<FPerInstanceLightmapData> PerInstanceLightmapData;

        [Location("FArchive& operator<<(FArchive& Ar, FMeshMapBuildData& MeshMapBuildData)")]
        public ITransferible Move(Transfer transfer)
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

        public ITransferible Move(Transfer transfer)
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
                if (Supports.VolumetricLightmaps)
                {
                    transfer.Move(ref LevelPrecomputedVolumetricLightmapBuildData);
                }
                transfer.Move(ref LightBuildData);
                if (Supports.MoveReflectionCaptureDataToMapBuildData)
                {
                    transfer.Move(ref ReflectionCaptureBuildData);
                }
                if (Supports.SkyAtmosphereStaticLightingVersioning)
                {
                    transfer.Move(ref SkyAtmosphereBuildData);
                }
            }
            return this;
        }

        public class FLightComponentMapBuildData : ITransferible
        {
            public ITransferible Move(Transfer transfer)
            {
                throw new NotImplementedException();
            }
        }

        public class FReflectionCaptureMapBuildData : FReflectionCaptureData, ITransferible
        {
            public Int32 CubemapSize;
            public float AverageBrightness;
            public float Brightness;
            public UTextureCube EncodedCaptureData;
            public List<byte> EncodedHDRCapturedData;
            public List<byte> StrippedData;

            [Location("FArchive& operator<<(FArchive& Ar, FReflectionCaptureMapBuildData& ReflectionCaptureMapBuildData)")]
            public ITransferible Move(Transfer transfer)
            {
                transfer.Move(ref CubemapSize);
                transfer.Move(ref AverageBrightness);
                if (Supports.StoreReflectionCaptureBrightnessForCooking && !Supports.ExcludeBrightnessFromEncodedHDRCubemap)
                {
                    transfer.Move(ref Brightness);
                }
                transfer.Move(ref FullHDRCapturedData);
                if (Supports.StoreReflectionCaptureCompressedMobile && !Supports.StoreReflectionCaptureEncodedHDRDataInRG11B10Format)
                {
                    transfer.MoveObject(ref EncodedCaptureData);
                }
                else
                {
                    if (Supports.StoreReflectionCaptureEncodedHDRDataInRG11B10Format)
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
            public List<byte> FullHDRCapturedData;
        }

        public class FSkyAtmosphereMapBuildData : ITransferible
        {
            [Location("FArchive& operator<<(FArchive& Ar, FSkyAtmosphereMapBuildData& Data)")]
            public ITransferible Move(Transfer transfer)
            {
                return this;
            }
        }
    }
}
