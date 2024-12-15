namespace AssetTool
{
    [TransferibleStruct("SkeletalMeshSamplingLODBuiltData")]
    public class FSkeletalMeshSamplingLODBuiltData : ITransferible
    {
        public FSkeletalMeshAreaWeightedTriangleSampler AreaWeightedSampler;

        [Location("bool FSkeletalMeshSamplingLODBuiltData::Serialize(FArchive& Ar)")]
        public ITransferible Move(Transfer transfer)
        {
            transfer.Move(ref AreaWeightedSampler);
            return this;
        }
    }

    public class FSkeletalMeshAreaWeightedTriangleSampler : FWeightedRandomSampler
    {
    }

    public class FWeightedRandomSampler : ITransferible
    {
        public List<float> Prob;
        public List<Int32> Alias;
        public float TotalWeight;

        [Location("void FWeightedRandomSampler::Serialize(FArchive& Ar)")]
        public ITransferible Move(Transfer transfer)
        {
            transfer.Move(ref Prob);
            transfer.Move(ref Alias);
            transfer.Move(ref TotalWeight);
            return this;
        }
    }

    [TransferibleStruct("SkeletalMeshSamplingRegionBuiltData")]
    public class FSkeletalMeshSamplingRegionBuiltData : ITransferible
    {
        public List<Int32> TriangleIndices;
        public List<Int32> BoneIndices;
        public FSkeletalMeshAreaWeightedTriangleSampler AreaWeightedSampler;
        public List<Int32> Vertices;

        public ITransferible Move(Transfer transfer)
        {
            transfer.Move(ref TriangleIndices);
            transfer.Move(ref BoneIndices);
            transfer.Move(ref AreaWeightedSampler);
            if (Supports.SkeletalMeshVertexSampling)
            {
                transfer.Move(ref Vertices);
            }
            return this;
        }
    }
}
