namespace AssetTool.Geometry
{
    public class TDynamicVertexSkinWeightsAttribute<ParentType> : TDynamicAttributeBase, ITransferible<bool>
    {
        public bool bUseCompression;
        public TDynamicVector<AnimationCore.FBoneWeights> VertexBoneWeights;
        public TDynamicVector<AnimationCore.FBoneWeights> VertexBoneWeightsCompact;

        [Location("void Serialize(FArchive& Ar, const FCompactMaps* CompactMaps, bool bUseCompression)")]
        public override ITransferible Move(Transfer transfer)
        {
            transfer.Move(ref bUseCompression);
            if (!bUseCompression)
            {
                bool bUseVertexCompactMap = false; //@@@
                if (!bUseVertexCompactMap)
                {
                    transfer.Move(ref VertexBoneWeights, false, false);
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            else
            {
                throw new NotImplementedException();
            }
            return this;
        }

        public ITransferible Move(Transfer transfer, bool arg1)
        {
            throw new NotImplementedException();
        }
    }
}
