namespace AssetTool
{
    public class FImportedSkinWeightProfileData : ITransferible
    {
        public List<FRawSkinWeight> SkinWeights;
        public List<FVertInfluence> SourceModelInfluences;

        [Location("FArchive& operator<<(FArchive& Ar, FImportedSkinWeightProfileData& ProfileData)")]
        public ITransferible Move(Transfer transfer)
        {
            transfer.Move(ref SkinWeights);
            transfer.Move(ref SourceModelInfluences);
            return this;
        }
    }

    public class FRawSkinWeight : ITransferible
    {
        public FBoneIndexType[] InfluenceBones = new FBoneIndexType[Consts.MAX_TOTAL_INFLUENCES];
        public UInt16[] InfluenceWeights = new UInt16[Consts.MAX_TOTAL_INFLUENCES];

        [Location("FArchive& operator<<(FArchive& Ar, FRawSkinWeight& OverrideEntry)")]
        public ITransferible Move(Transfer transfer)
        {
            if (!Supports.UnlimitedBoneInfluences)
            {
                for (int InfluenceIndex = 0; InfluenceIndex < Consts.EXTRA_BONE_INFLUENCES; ++InfluenceIndex)
                {
                    if (!Supports.IncreaseBoneIndexLimitPerChunk)
                    {
                        InfluenceBones[InfluenceIndex] = transfer.Move((byte)InfluenceBones[InfluenceIndex]);
                    }
                    else
                    {
                        transfer.Move(ref InfluenceBones[InfluenceIndex]);
                    }
                    InfluenceWeights[InfluenceIndex] = transfer.Move((byte)InfluenceWeights[InfluenceIndex]);
                }
            }
            else if (!Supports.IncreasedSkinWeightPrecision)
            {
                for (int InfluenceIndex = 0; InfluenceIndex < Consts.MAX_TOTAL_INFLUENCES; ++InfluenceIndex)
                {
                    transfer.Move(ref InfluenceBones[InfluenceIndex]);
                    InfluenceWeights[InfluenceIndex] = transfer.Move((byte)InfluenceWeights[InfluenceIndex]);
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
}
