///namespace AssetTool
///{
///    [Location("FArchive& operator<<(FArchive& Ar, FMeshUVChannelInfo& ChannelData)")]
///    public class FMeshUVChannelInfo
///    {
///        public const string StructName = "MeshUVChannelInfo";
///
///        public FBool bInitialized;
///        public FBool bOverrideDensities;
///        public float[] LocalUVDensities = new float[Consts.TEXSTREAM_MAX_NUM_UVCHANNELS];
///
///        public FMeshUVChannelInfo Read(BinaryReader reader)
///        {
///            reader.Read(ref bInitialized);
///            reader.Read(ref bOverrideDensities);
///            for (int i = 0; i < Consts.TEXSTREAM_MAX_NUM_UVCHANNELS; i++)
///            {
///                LocalUVDensities[i] = reader.ReadSingle();
///            }
///            return this;
///        }
///        public void Write(BinaryWriter writer)
///        {
///            writer.Write(bInitialized);
///            writer.Write(bOverrideDensities);
///            for (int i = 0; i < LocalUVDensities.Length; i++)
///            {
///                writer.Write(LocalUVDensities[i]);
///            }
///        }
///    }
///}
