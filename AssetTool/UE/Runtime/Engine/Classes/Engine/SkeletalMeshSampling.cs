namespace AssetTool
{
    [TransferableStruct("SkeletalMeshSamplingLODBuiltData")]
    public class FSkeletalMeshSamplingLODBuiltData : ITransferable
    {
        public FSkeletalMeshAreaWeightedTriangleSampler AreaWeightedSampler;

        [Location("bool FSkeletalMeshSamplingLODBuiltData::Serialize(FArchive& Ar)")]
        public ITransferable Move(Transfer transfer)
        {
            transfer.Move(ref AreaWeightedSampler);
            return this;
        }
    }

    public class FSkeletalMeshAreaWeightedTriangleSampler : FWeightedRandomSampler
    {
    }

    public class FWeightedRandomSampler : ITransferable
    {
        public float[] Prob;
        public Int32[] Alias;
        public float TotalWeight;

        [Location("void FWeightedRandomSampler::Serialize(FArchive& Ar)")]
        public ITransferable Move(Transfer transfer)
        {
            transfer.Move(ref Prob);
            transfer.Move(ref Alias);
            transfer.Move(ref TotalWeight);
            return this;
        }
    }

    [TransferableStruct("SkeletalMeshSamplingRegionBuiltData")]
    public class FSkeletalMeshSamplingRegionBuiltData : ITransferable
    {
        public Int32[] TriangleIndices;
        public Int32[] BoneIndices;
        public FSkeletalMeshAreaWeightedTriangleSampler AreaWeightedSampler;
        public Int32[] Vertices;

        public ITransferable Move(Transfer transfer)
        {
            transfer.Move(ref TriangleIndices);
            transfer.Move(ref BoneIndices);
            transfer.Move(ref AreaWeightedSampler);
            if (transfer.Supports.SkeletalMeshVertexSampling)
            {
                transfer.Move(ref Vertices);
            }
            return this;
        }
    }
}
