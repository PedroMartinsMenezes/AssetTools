namespace AssetTool
{
    [TransferibleStruct("SkeletalMeshSamplingLODBuiltData")]
    public class FSkeletalMeshSamplingLODBuiltData : ITransferible
    {
        public List<TInt32> TriangleIndices = [];
        public List<TInt32> BoneIndices = [];
        public FSkeletalMeshAreaWeightedTriangleSampler AreaWeightedSampler = new();
        public List<TInt32> Vertices;

        public ITransferible Move(Transfer transfer)
        {
            transfer.Move(ref TriangleIndices);

            transfer.Move(ref BoneIndices);

            AreaWeightedSampler.Move(transfer);

            if (Supports.CustomVer(FNiagaraObjectVersion.Enums.SkeletalMeshVertexSampling))
            {
                transfer.Move(ref Vertices);
            }

            return this;
        }
    }

    public class FSkeletalMeshAreaWeightedTriangleSampler : ITransferible
    {
        public ITransferible Move(Transfer transfer)
        {
            return this;
        }
    }
}
