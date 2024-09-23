namespace AssetTool
{
    public class FSkeletalMeshModel
    {
        public FStripDataFlags StripFlags;
        public FGuid SkeletalMeshModelGUID;
        public FBool bGuidIsHash;
        public List<FSkeletalMeshLODModel> LODModels;
        public List<FReductionBaseSkeletalMeshBulkData> OriginalReductionSourceMeshData_DEPRECATED;
        public List<FInlineReductionCacheData> InlineReductionCacheDatas;

        [Location("void FSkeletalMeshModel::Serialize(FArchive& Ar, USkinnedAsset* Owner)")]
        public void Move(Transfer transfer)
        {
            bool bIsEditorDataStripped = false;
            if (Supports.CustomVer(FFortniteMainBranchObjectVersion.Enums.AllowSkeletalMeshToReduceTheBaseLOD))
            {
                StripFlags ??= new();
                StripFlags.Move(transfer);
                bIsEditorDataStripped = StripFlags.IsEditorDataStripped();
            }

            LODModels.Resize(transfer);
            LODModels.ForEach(x => x.Move(transfer));

            if (Supports.CustomVer(FSkeletalMeshCustomVersion.Enums.SplitModelAndRenderData))
            {
                transfer.Move(ref SkeletalMeshModelGUID);
                transfer.Move(ref bGuidIsHash);
            }

            if (!bIsEditorDataStripped)
            {
                bool a = Supports.CustomVer(FFortniteMainBranchObjectVersion.Enums.AllowSkeletalMeshToReduceTheBaseLOD);
                bool b = Supports.CustomVer(FUE5MainStreamObjectVersion.Enums.ConvertReductionBaseSkeletalMeshBulkDataToInlineReductionCacheData);
                if (a && b)
                {
                    OriginalReductionSourceMeshData_DEPRECATED.Resize(transfer);
                    OriginalReductionSourceMeshData_DEPRECATED.ForEach(x => x.Move(transfer));
                }
            }

            if (Supports.CustomVer(FUE5MainStreamObjectVersion.Enums.ConvertReductionBaseSkeletalMeshBulkDataToInlineReductionCacheData))
            {
                InlineReductionCacheDatas.Resize(transfer);
                InlineReductionCacheDatas.ForEach(x => x.Move(transfer));
            }
        }
    }
}
