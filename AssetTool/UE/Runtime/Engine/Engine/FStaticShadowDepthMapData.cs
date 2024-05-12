namespace AssetTool
{
    public class FStaticShadowDepthMapData
    {
        public DMatrix4x4 WorldToLight = new();
        public Int32 ShadowMapSizeX;
        public Int32 ShadowMapSizeY;
        public List<UInt16> DepthSamples = [];

        public FStaticShadowDepthMapData Move(Transfer transfer)
        {
            WorldToLight.Move(transfer);
            transfer.Move(ref ShadowMapSizeX);
            transfer.Move(ref ShadowMapSizeY);
            DepthSamples.Resize(transfer).ForEach(x => transfer.Move(ref x));
            return this;
        }
    }
}
