namespace AssetTool
{
    public class FSkeletalMeshModel : ITransferable<bool>
    {
        public FStripDataFlags StripFlags;
        public FGuid SkeletalMeshModelGUID;
        public FBool bGuidIsHash;
        public List<FSkeletalMeshLODModel> LODModels;
        public List<FReductionBaseSkeletalMeshBulkData> OriginalReductionSourceMeshData_DEPRECATED;
        public List<FInlineReductionCacheData> InlineReductionCacheDatas;

        [Location("void FSkeletalMeshModel::Serialize(FArchive& Ar, USkinnedAsset* Owner)")]
        public ITransferable Move(Transfer transfer, bool bHasVertexColors)
        {
            bool bIsEditorDataStripped = false;
            if (transfer.Supports.AllowSkeletalMeshToReduceTheBaseLOD)
            {
                transfer.Move(ref StripFlags);
                bIsEditorDataStripped = StripFlags.IsEditorDataStripped();
            }

            transfer.Resize(ref LODModels);
            LODModels.ForEach(x => x.Move(transfer, bHasVertexColors));

            if (transfer.Supports.SplitModelAndRenderData)
            {
                transfer.Move(ref SkeletalMeshModelGUID);
                transfer.Move(ref bGuidIsHash);
            }

            if (!bIsEditorDataStripped)
            {
                bool a = transfer.Supports.AllowSkeletalMeshToReduceTheBaseLOD;
                bool b = transfer.Supports.ConvertReductionBaseSkeletalMeshBulkDataToInlineReductionCacheData;
                if (a && !b)
                {
                    transfer.Move(ref OriginalReductionSourceMeshData_DEPRECATED);
                }
                if (transfer.Supports.ConvertReductionBaseSkeletalMeshBulkDataToInlineReductionCacheData)
                {
                    transfer.Move(ref InlineReductionCacheDatas);
                }
            }

            return this;
        }

        public ITransferable Move(Transfer transfer)
        {
            throw new NotImplementedException();
        }
    }
}
