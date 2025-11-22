namespace AssetTool
{
    public class FCurveMetaData : ITransferable
    {
        public FAnimCurveType Type;
        public List<FBoneReference> LinkedBones;
        public byte MaxLOD;

        public ITransferable Move(Transfer transfer)
        {
            transfer.Move(ref Type);
            transfer.Move(ref LinkedBones);
            if (transfer.Supports.AddLODToCurveMetaData)
            {
                transfer.Move(ref MaxLOD);
            }
            return this;
        }
    }

    public class FAnimCurveType : ITransferable
    {
        public FBool bMaterial;
        public FBool bMorphtarget;

        public ITransferable Move(Transfer transfer)
        {
            transfer.Move(ref bMaterial);
            transfer.Move(ref bMorphtarget);
            return this;
        }
    }
}