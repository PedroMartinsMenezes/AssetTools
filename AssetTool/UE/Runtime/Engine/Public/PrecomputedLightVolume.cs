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
        public List<FVolumeLightingSample> DummySamples;

        [Location("FArchive& operator<<(FArchive& Ar,FPrecomputedLightVolumeData& Volume)")]
        public virtual ITransferible Move(Transfer transfer)
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

                LoadVolumeLightSamples(transfer, NumSHSamples, ref HighQualitySamples);

                if (transfer.Supports.VER_UE4_VOLUME_SAMPLE_LOW_QUALITY_SUPPORT)
                {
                    LoadVolumeLightSamples(transfer, NumSHSamples, ref LowQualitySamples);
                }
            }
            return this;
        }

        private void LoadVolumeLightSamples(Transfer transfer, int32 ArchiveNumSHSamples, ref List<FVolumeLightingSample> Samples)
        {
            if (ArchiveNumSHSamples == Consts.NUM_INDIRECT_LIGHTING_SH_COEFFICIENTS)
            {
                Samples ??= new();
                transfer.Resize(ref Samples);
                Samples.ForEach(x => x.Move(transfer, 3));
            }
            else if (ArchiveNumSHSamples == 9)
            {
                DummySamples ??= new();
                transfer.Resize(ref DummySamples);
                DummySamples.ForEach(x => x.Move(transfer, 3));
            }
            else
            {
                DummySamples ??= new();
                transfer.Resize(ref DummySamples);
                DummySamples.ForEach(x => x.Move(transfer, 2));
            }
        }
    }

    public class FPrecomputedLightVolumeDataPtr : FPrecomputedLightVolumeData, ITransferible
    {
        [Location("FArchive& operator<<(FArchive& Ar, FPrecomputedLightVolumeData*& Volume)")]
        public override ITransferible Move(Transfer transfer)
        {
            transfer.Move(ref bValid);
            if (bValid)
            {
                base.Move(transfer);
            }
            return this;
        }
    }

    public class FVolumeLightingSample : ITransferible<int>
    {
        public FVector3f Position;
        public float Radius;
        public FSHVectorRGB3 Lighting;
        public FColor PackedSkyBentNormal;
        public float DirectionalLightShadowing;

        public ITransferible Move(Transfer transfer)
        {
            throw new NotImplementedException();
        }

        public ITransferible Move(Transfer transfer, int SHOrder)
        {
            if (SHOrder == 3)
                return MoveOrder3(transfer);
            else if (SHOrder == 2)
                return MoveOrder2(transfer);
            else
                throw new NotImplementedException();
        }

        [Location("FArchive& operator<<(FArchive& Ar, TVolumeLightingSample<3>& Sample)")]
        public ITransferible MoveOrder3(Transfer transfer)
        {
            transfer.Move(ref Position);
            transfer.Move(ref Radius);
            transfer.Move(ref Lighting);
            transfer.Move(ref PackedSkyBentNormal);

            transfer.Move(ref DirectionalLightShadowing);
            return this;
        }

        [Location("FArchive& operator<<(FArchive& Ar, TVolumeLightingSample<2>& Sample)")]
        public ITransferible MoveOrder2(Transfer transfer)
        {
            transfer.Move(ref Position);
            transfer.Move(ref Radius);
            transfer.Move(ref Lighting);
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
