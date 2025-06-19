namespace AssetTool
{
    public class FStaticShadowDepthMapData : ITransferible
    {
        public FMatrix WorldToLight;
        public Int32 ShadowMapSizeX;
        public Int32 ShadowMapSizeY;
        public UInt16[] DepthSamples;

        [Location("FArchive& operator<<(FArchive& Ar, FStaticShadowDepthMapData& ShadowMapData)")]
        public ITransferible Move(Transfer transfer)
        {
            transfer.Move(ref WorldToLight);
            transfer.Move(ref ShadowMapSizeX);
            transfer.Move(ref ShadowMapSizeY);
            transfer.Move(ref DepthSamples);
            return this;
        }
    }
}
