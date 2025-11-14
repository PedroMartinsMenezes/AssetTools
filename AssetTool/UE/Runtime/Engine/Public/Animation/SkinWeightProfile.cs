namespace AssetTool
{
    public class FImportedSkinWeightProfileData : ITransferable
    {
        public List<FRawSkinWeight> SkinWeights;
        public List<FVertInfluence> SourceModelInfluences;

        [Location("FArchive& operator<<(FArchive& Ar, FImportedSkinWeightProfileData& ProfileData)")]
        public ITransferable Move(Transfer transfer)
        {
            transfer.Move(ref SkinWeights);
            transfer.Move(ref SourceModelInfluences);
            return this;
        }
    }

    public class FRawSkinWeight : ITransferable
    {
        public UInt16[] InfluenceBones = new UInt16[Consts.MAX_TOTAL_INFLUENCES];
        public UInt16[] InfluenceWeights = new UInt16[Consts.MAX_TOTAL_INFLUENCES];

        [Location("FArchive& operator<<(FArchive& Ar, FRawSkinWeight& OverrideEntry)")]
        public ITransferable Move(Transfer transfer)
        {
            if (!transfer.Supports.UnlimitedBoneInfluences)
            {
                for (int InfluenceIndex = 0; InfluenceIndex < Consts.EXTRA_BONE_INFLUENCES; ++InfluenceIndex)
                {
                    if (!transfer.Supports.IncreaseBoneIndexLimitPerChunk)
                    {
                        transfer.MoveAsByte(ref InfluenceBones[InfluenceIndex]);
                    }
                    else
                    {
                        transfer.Move(ref InfluenceBones[InfluenceIndex]);
                    }
                    transfer.MoveAsByte(ref InfluenceWeights[InfluenceIndex]);
                }
            }
            else if (!transfer.Supports.IncreasedSkinWeightPrecision)
            {
                for (int InfluenceIndex = 0; InfluenceIndex < Consts.MAX_TOTAL_INFLUENCES; ++InfluenceIndex)
                {
                    transfer.Move(ref InfluenceBones[InfluenceIndex]);
                    transfer.MoveAsByte(ref InfluenceWeights[InfluenceIndex]);
                }
            }
            else
            {
                for (int InfluenceIndex = 0; InfluenceIndex < Consts.MAX_TOTAL_INFLUENCES; ++InfluenceIndex)
                {
                    transfer.Move(ref InfluenceBones[InfluenceIndex]);
                    transfer.Move(ref InfluenceWeights[InfluenceIndex]);
                }
            }
            return this;
        }
    }

    public class FSkinWeightProfilesData : ITransferable
    {
        public Dictionary<FName, FRuntimeSkinWeightProfileData> OverrideData;

        [Location("FArchive& operator<<(FArchive& Ar, FSkinWeightProfilesData& LODData)")]
        public ITransferable Move(Transfer transfer)
        {
            transfer.Move(ref OverrideData);
            return this;
        }
    }

    public class FRuntimeSkinWeightProfileData : ITransferable
    {
        public List<FRawSkinWeight> SkinWeights;
        public List<FVertInfluence> SourceModelInfluences;

        [Location("FArchive& operator<<(FArchive& Ar, FImportedSkinWeightProfileData& ProfileData)")]
        public ITransferable Move(Transfer transfer)
        {
            transfer.Move(ref SkinWeights);
            transfer.Move(ref SourceModelInfluences);
            return this;
        }
    }
}
