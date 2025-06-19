namespace AssetTool
{
    [JsonAsset("AnimCurveMetaData")]
    public class UAnimCurveMetaData : UAssetUserData
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    public class FCurveMetaData : ITransferible
    {
        public FAnimCurveType Type;
        public List<FBoneReference> LinkedBones;
        public byte MaxLOD;

        public ITransferible Move2(Transfer transfer)
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

    public class FAnimCurveType : ITransferible
    {
        public FBool bMaterial;
        public FBool bMorphtarget;

        public ITransferible Move2(Transfer transfer)
        {
            transfer.Move(ref bMaterial);
            transfer.Move(ref bMorphtarget);
            return this;
        }
    }
}