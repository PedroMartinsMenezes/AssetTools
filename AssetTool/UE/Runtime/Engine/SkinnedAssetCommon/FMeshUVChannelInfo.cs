﻿namespace AssetTool
{
    public class FMeshUVChannelInfo
    {
        public FBool bInitialized;
        public FBool bOverrideDensities;
        public float[] LocalUVDensities = new float[Consts.TEXSTREAM_MAX_NUM_UVCHANNELS];

        [Location("FArchive& operator<<(FArchive& Ar, FMeshUVChannelInfo& ChannelData)")]
        public FMeshUVChannelInfo Move(Transfer transfer)
        {
            transfer.Move(ref bInitialized);
            transfer.Move(ref bOverrideDensities);
            transfer.Move(ref LocalUVDensities, Consts.TEXSTREAM_MAX_NUM_UVCHANNELS);

            return this;
        }
    }
}
