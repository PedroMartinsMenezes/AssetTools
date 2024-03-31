namespace AssetTool
{
    [Location("FArchive& operator<<(FArchive& Ar, FMeshUVChannelInfo& ChannelData)")]
    public class FMeshUVChannelInfo
    {
        public FBool bInitialized;
        public FBool bOverrideDensities;
        public float[] LocalUVDensities = new float[Consts.TEXSTREAM_MAX_NUM_UVCHANNELS];

        public FMeshUVChannelInfo Read(BinaryReader reader)
        {
            reader.Read(ref bInitialized);
            reader.Read(ref bOverrideDensities);
            LocalUVDensities = Enumerable.Range(0, Consts.TEXSTREAM_MAX_NUM_UVCHANNELS).Select(x => reader.ReadSingle()).ToArray();
            return this;
        }
        public void Write(BinaryWriter writer)
        {
            writer.Write(bInitialized);
            writer.Write(bOverrideDensities);
            LocalUVDensities.ToList().ForEach(x => writer.Write(x));
        }
    }
}
