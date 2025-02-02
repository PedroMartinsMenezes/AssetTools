namespace AssetTool
{
    public class FPrecomputedLightVolumeData : ITransferible
    {
        public FBool bValid;
        public FBool bVolumeInitialized;
        public FBox Bounds;
        public float SampleSpacing;
        public Int32 NumSHSamples = 4;
        public List<FVolumeLightingSample> HighQualitySamples;
        public List<FVolumeLightingSample> LowQualitySamples;
        public List<FVolumeLightingSample> DummySamples3;
        public List<FVolumeLightingSample2Band> DummySamples2;

        [Location("FArchive& operator<<(FArchive& Ar, FPrecomputedLightVolumeData*& Volume)")]
        public ITransferible Move(Transfer transfer)
        {
            transfer.Move(ref bValid);
            if (bValid)
            {
                transfer.Move(ref bVolumeInitialized);
                if (bVolumeInitialized)
                {
                    transfer.Move(ref Bounds);
                    transfer.Move(ref SampleSpacing);
                    if (Supports.IndirectLightingCache3BandSupport)
                    {
                        transfer.Move(ref NumSHSamples);
                    }
                    LoadVolumeLightSamples(transfer, NumSHSamples, ref HighQualitySamples);
                    if (Supports.VER_UE4_VOLUME_SAMPLE_LOW_QUALITY_SUPPORT)
                    {
                        LoadVolumeLightSamples(transfer, NumSHSamples, ref LowQualitySamples);
                    }
                }
            }
            return this;
        }

        private void LoadVolumeLightSamples(Transfer transfer, int32 ArchiveNumSHSamples, ref List<FVolumeLightingSample> Samples)
        {
            Samples ??= new();
            if (ArchiveNumSHSamples == Consts.NUM_INDIRECT_LIGHTING_SH_COEFFICIENTS)
            {
                transfer.Move(ref Samples);
            }
            else if (ArchiveNumSHSamples == 9)
            {
                transfer.Move(ref DummySamples3);
            }
            else
            {
                transfer.Move(ref DummySamples2);
            }
        }
    }

    public class FVolumeLightingSample : ITransferible
    {
        public FVector3f Position;
        public float Radius;
        public TSHVectorRGB3 Lighting;
        public FColor PackedSkyBentNormal;
        public float DirectionalLightShadowing;

        [Location("FArchive& operator<<(FArchive& Ar, TVolumeLightingSample<3>& Sample)")]
        public ITransferible Move(Transfer transfer)
        {
            transfer.Move(ref Position);//8012
            transfer.Move(ref Radius);//8016
            transfer.Move(ref Lighting);//8124  (size 108)
            transfer.Move(ref PackedSkyBentNormal);
            transfer.Move(ref DirectionalLightShadowing);
            return this;
        }
    }

    public class FVolumeLightingSample2Band : ITransferible
    {
        public ITransferible Move(Transfer transfer)
        {
            throw new NotImplementedException();
        }
    }
}
