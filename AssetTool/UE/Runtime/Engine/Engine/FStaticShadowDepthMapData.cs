namespace AssetTool
{
    public class FStaticShadowDepthMapData
    {
        public DMatrix4x4 WorldToLight = new();
        public Int32 ShadowMapSizeX;
        public Int32 ShadowMapSizeY;
        public List<FFloat16> DepthSamples = [];

        public FStaticShadowDepthMapData Read(BinaryReader reader)
        {
            WorldToLight.Read(reader);
            ShadowMapSizeX = reader.ReadInt32();
            ShadowMapSizeY = reader.ReadInt32();
            DepthSamples.Resize(reader.ReadInt32());
            DepthSamples.ForEach(x => reader.Read(ref x.Encoded));
            return this;
        }
        public void Write(BinaryWriter writer)
        {
            WorldToLight.Write(writer);
            writer.Write(ShadowMapSizeX);
            writer.Write(ShadowMapSizeY);
            writer.Write(DepthSamples.Count);
            DepthSamples.ForEach(x => writer.Write(x.Encoded));
        }
    }
}
