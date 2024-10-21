namespace AssetTool
{
    public class FPrecomputedVolumetricLightmapData : FRenderResource, ITransferible
    {
        public FBool bValid;
        public FBox Bounds;
        public FIntVector IndirectionTextureDimensions;
        public FVolumetricLightmapDataLayer IndirectionTexture;
        public Int32 BrickSize;
        public FIntVector BrickDataDimensions;
        public FVolumetricLightmapBrickData BrickData;
        public FVolumetricLightmapDataLayer Dummy;
        public List<FIntVector> SubLevelBrickPositions;
        public List<FColor> IndirectionTextureOriginalValues;

        [Location("FArchive& operator<<(FArchive& Ar, FPrecomputedVolumetricLightmapData*& Volume)")]
        public ITransferible Move(Transfer transfer)
        {
            transfer.Move(ref bValid);
            if (bValid ?? false)
            {
                transfer.Move(ref Bounds);
                transfer.Move(ref IndirectionTextureDimensions);
                transfer.Move(ref IndirectionTexture);

                transfer.Move(ref BrickSize);
                transfer.Move(ref BrickDataDimensions);

                transfer.Move(ref BrickData.AmbientVector);
                transfer.Move(ref BrickData.SHCoefficients);
                transfer.Move(ref BrickData.SkyBentNormal);
                transfer.Move(ref BrickData.DirectionalLightShadowing);

                if (Supports.LQVolumetricLightmapLayers)
                {
                    if (!Supports.MobileStationaryLocalLights)
                    {
                        transfer.Move(ref Dummy);
                    }
                }

                if (Supports.VolumetricLightmapStreaming)
                {
                    transfer.Move(ref SubLevelBrickPositions);
                    transfer.Move(ref IndirectionTextureDimensions);
                }
            }
            return this;
        }
    }

    public class FVolumetricLightmapDataLayer : FResourceBulkDataInterface, ITransferible
    {
        public List<byte> Data;
        public FString PixelFormatString;

        [Location("FArchive& operator<<(FArchive& Ar,FVolumetricLightmapDataLayer& Layer)")]
        public ITransferible Move(Transfer transfer)
        {
            transfer.Move(ref Data);
            transfer.Move(ref PixelFormatString);
            return this;
        }
    }

    public class FVolumetricLightmapBasicBrickDataLayers
    {
        public FVolumetricLightmapDataLayer AmbientVector;
        public FVolumetricLightmapDataLayer[] SHCoefficients = [new(), new(), new(), new(), new(), new()];
        public FVolumetricLightmapDataLayer SkyBentNormal;
        public FVolumetricLightmapDataLayer DirectionalLightShadowing;
    }

    public class FVolumetricLightmapBrickData : FVolumetricLightmapBasicBrickDataLayers
    {
    }
}
