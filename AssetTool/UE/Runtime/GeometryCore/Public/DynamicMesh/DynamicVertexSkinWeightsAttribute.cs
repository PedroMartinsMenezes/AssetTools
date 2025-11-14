namespace AssetTool.Geometry
{
    public class TDynamicVertexSkinWeightsAttribute<ParentType> : TDynamicAttributeBase, ITransferable<FCompactMaps>
    {
        public bool bUseCompression;
        public TDynamicVector<AnimationCore.FBoneWeights> VertexBoneWeights;
        public TDynamicVector<AnimationCore.FBoneWeights> VertexBoneWeightsCompact;
        public int32[] Buffer;

        [Location("void Serialize(FArchive& Ar, const FCompactMaps* CompactMaps, bool bUseCompression)")]
        public ITransferable Move(Transfer transfer, FCompactMaps CompactMaps)
        {
            transfer.Move(ref bUseCompression);
            bool bUseVertexCompactMap = CompactMaps.VertexMapIsSet();
            if (!bUseCompression)
            {
                if (!bUseVertexCompactMap)
                {
                    transfer.Move(ref VertexBoneWeights, false, false);
                }
                else
                {
                    transfer.Move(ref VertexBoneWeightsCompact, false, false);
                }
            }
            else
            {
                transfer.Move(ref Buffer);
            }
            return this;
        }

        public ITransferable Move(Transfer transfer, FCompactMaps CompactMaps, bool useCompression)
        {
            throw new NotImplementedException();
        }
    }
}
