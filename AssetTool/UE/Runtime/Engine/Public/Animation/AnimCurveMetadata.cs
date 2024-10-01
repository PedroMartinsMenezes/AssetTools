namespace AssetTool
{
    public class FCurveMetaData : ITransferible
    {
        public FAnimCurveType Type;
        public List<FBoneReference> LinkedBones;
        public byte MaxLOD;

        public ITransferible Move(Transfer transfer)
        {
            transfer.Move(ref Type);
            transfer.Move(ref LinkedBones);
            if (Supports.AddLODToCurveMetaData)
            {
                transfer.Move(ref MaxLOD);
            }
            return this;
        }
    }

    public class FAnimCurveType : ITransferible
    {
        public FBool bMaterial;
        public FBool bMorphtarget;

        public ITransferible Move(Transfer transfer)
        {
            transfer.Move(ref bMaterial);
            transfer.Move(ref bMorphtarget);
            return this;
        }
    }
}