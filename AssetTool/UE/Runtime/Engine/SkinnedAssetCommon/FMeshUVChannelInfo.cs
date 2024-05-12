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
            var transfer = GlobalObjects.Transfer;
            transfer.Move(ref bInitialized);
            transfer.Move(ref bOverrideDensities);
            transfer.Move(ref LocalUVDensities, Consts.TEXSTREAM_MAX_NUM_UVCHANNELS);

            return this;
        }
        public void Write(BinaryWriter writer)
        {
            var transfer = GlobalObjects.Transfer;
            transfer.Move(ref bInitialized);
            transfer.Move(ref bOverrideDensities);
            transfer.Move(ref LocalUVDensities, Consts.TEXSTREAM_MAX_NUM_UVCHANNELS);
        }
    }
}
