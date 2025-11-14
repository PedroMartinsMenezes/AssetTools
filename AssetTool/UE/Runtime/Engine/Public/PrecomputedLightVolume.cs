namespace AssetTool
{
    public class FPrecomputedLightVolumeData : ITransferable
    {
        public FBool bValid;
        public FBool bVolumeInitialized;
        public FBox Bounds;
        public float SampleSpacing;
        public Int32 NumSHSamples = 4;
        public List<FVolumeLightingSample> HighQualitySamples;
        public List<FVolumeLightingSample> LowQualitySamples;
        public List<FVolumeLightingSample> DummySamplesHigh9;
        public List<FVolumeLightingSample> DummySamplesHighOther;
        public List<FVolumeLightingSample> DummySamplesLow9;
        public List<FVolumeLightingSample> DummySamplesLowOther;

        [Location("FArchive& operator<<(FArchive& Ar,FPrecomputedLightVolumeData& Volume)")]
        public virtual ITransferable Move(Transfer transfer)
        {
            transfer.Move(ref bVolumeInitialized);
            if (bVolumeInitialized)
            {
                transfer.Move(ref Bounds);
                transfer.Move(ref SampleSpacing);

                if (transfer.Supports.IndirectLightingCache3BandSupport)
                {
                    transfer.Move(ref NumSHSamples);
                }

                LoadVolumeLightSamplesHigh(transfer, NumSHSamples);

                if (transfer.Supports.VER_UE4_VOLUME_SAMPLE_LOW_QUALITY_SUPPORT)
                {
                    LoadVolumeLightSamplesLow(transfer, NumSHSamples);
                }
            }
            return this;
        }

        private void LoadVolumeLightSamplesHigh(Transfer transfer, int32 ArchiveNumSHSamples)
        {
            if (ArchiveNumSHSamples == Consts.NUM_INDIRECT_LIGHTING_SH_COEFFICIENTS)
            {
                HighQualitySamples ??= new();
                transfer.Resize(ref HighQualitySamples);
                HighQualitySamples.ForEach(x => x.Move(transfer, 3));
            }
            else if (ArchiveNumSHSamples == 9)
            {
                DummySamplesHigh9 ??= new();
                transfer.Resize(ref DummySamplesHigh9);
                DummySamplesHigh9.ForEach(x => x.Move(transfer, 3));
            }
            else
            {
                DummySamplesHighOther ??= new();
                transfer.Resize(ref DummySamplesHighOther);
                DummySamplesHighOther.ForEach(x => x.Move(transfer, 2));
            }
        }

        private void LoadVolumeLightSamplesLow(Transfer transfer, int32 ArchiveNumSHSamples)
        {
            if (ArchiveNumSHSamples == Consts.NUM_INDIRECT_LIGHTING_SH_COEFFICIENTS)
            {
                LowQualitySamples ??= new();
                transfer.Resize(ref LowQualitySamples);
                LowQualitySamples.ForEach(x => x.Move(transfer, 3));
            }
            else if (ArchiveNumSHSamples == 9)
            {
                DummySamplesLow9 ??= new();
                transfer.Resize(ref DummySamplesLow9);
                DummySamplesLow9.ForEach(x => x.Move(transfer, 3));
            }
            else
            {
                DummySamplesLowOther ??= new();
                transfer.Resize(ref DummySamplesLowOther);
                DummySamplesLowOther.ForEach(x => x.Move(transfer, 2));
            }
        }
    }

    public class FPrecomputedLightVolumeDataPtr : FPrecomputedLightVolumeData, ITransferable
    {
        [Location("FArchive& operator<<(FArchive& Ar, FPrecomputedLightVolumeData*& Volume)")]
        public override ITransferable Move(Transfer transfer)
        {
            transfer.Move(ref bValid);
            if (bValid)
            {
                base.Move(transfer);
            }
            return this;
        }
    }

    public class FVolumeLightingSample : ITransferable<int>
    {
        public FVector3f Position;
        public float Radius;
        public FSHVectorRGB Lighting = new();
        public FColor PackedSkyBentNormal;
        public float DirectionalLightShadowing;

        public ITransferable Move(Transfer transfer)
        {
            throw new NotImplementedException();
        }

        public ITransferable Move(Transfer transfer, int SHOrder)
        {
            if (SHOrder == 3)
                return MoveOrder3(transfer);
            else if (SHOrder == 2)
                return MoveOrder2(transfer);
            else
                throw new NotImplementedException();
        }

        [Location("FArchive& operator<<(FArchive& Ar, TVolumeLightingSample<3>& Sample)")]
        public ITransferable MoveOrder3(Transfer transfer)
        {
            transfer.Move(ref Position);
            transfer.Move(ref Radius);
            Lighting.Move(transfer, 3);
            transfer.Move(ref PackedSkyBentNormal);

            transfer.Move(ref DirectionalLightShadowing);
            return this;
        }

        [Location("FArchive& operator<<(FArchive& Ar, TVolumeLightingSample<2>& Sample)")]
        public ITransferable MoveOrder2(Transfer transfer)
        {
            transfer.Move(ref Position);
            transfer.Move(ref Radius);
            Lighting.Move(transfer, 2);
            if (transfer.Supports.VER_UE4_SKY_BENT_NORMAL)
            {
                transfer.Move(ref PackedSkyBentNormal);
            }
            if (transfer.Supports.VER_UE4_VOLUME_SAMPLE_LOW_QUALITY_SUPPORT)
            {
                transfer.Move(ref DirectionalLightShadowing);
            }
            return this;
        }
    }
}
