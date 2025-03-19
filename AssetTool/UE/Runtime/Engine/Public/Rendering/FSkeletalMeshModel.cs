namespace AssetTool
{
    public class FSkeletalMeshModel : ITransferible
    {
        public FStripDataFlags StripFlags;
        public FGuid SkeletalMeshModelGUID;
        public FBool bGuidIsHash;
        public List<FSkeletalMeshLODModel> LODModels;
        public List<FReductionBaseSkeletalMeshBulkData> OriginalReductionSourceMeshData_DEPRECATED;
        public List<FInlineReductionCacheData> InlineReductionCacheDatas;

        [Location("void FSkeletalMeshModel::Serialize(FArchive& Ar, USkinnedAsset* Owner)")]
        public ITransferible Move(Transfer transfer)
        {
            bool bIsEditorDataStripped = false;
            if (Supports.AllowSkeletalMeshToReduceTheBaseLOD)
            {
                StripFlags ??= new();
                StripFlags.Move(transfer);
                bIsEditorDataStripped = StripFlags.IsEditorDataStripped();
            }

            transfer.Move(ref LODModels);

            if (Supports.SplitModelAndRenderData)
            {
                transfer.Move(ref SkeletalMeshModelGUID);
                transfer.Move(ref bGuidIsHash);
            }

            if (!bIsEditorDataStripped)
            {
                bool a = Supports.AllowSkeletalMeshToReduceTheBaseLOD;
                bool b = Supports.ConvertReductionBaseSkeletalMeshBulkDataToInlineReductionCacheData;
                if (a && !b)
                {
                    transfer.Move(ref OriginalReductionSourceMeshData_DEPRECATED);
                }
                if (Supports.ConvertReductionBaseSkeletalMeshBulkDataToInlineReductionCacheData)
                {
                    transfer.Move(ref InlineReductionCacheDatas);
                }
            }

            return this;
        }
    }
}
