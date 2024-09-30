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
            TriangleIndices.Resize(transfer);
            TriangleIndices.ForEach(x => x.Move(transfer));

            BoneIndices.Resize(transfer);
            BoneIndices.ForEach(x => x.Move(transfer));

            AreaWeightedSampler.Move(transfer);

            if (Supports.CustomVer(FNiagaraObjectVersion.Enums.SkeletalMeshVertexSampling))
            {
                Vertices ??= [];
                Vertices.Resize(transfer);
                Vertices.ForEach(x => x.Move(transfer));
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
