namespace AssetTool
{
    public class FReductionBaseSkeletalMeshBulkData : ITransferible
    {
        public FByteBulkData BulkData = new();

        [Location("void FReductionBaseSkeletalMeshBulkData::Serialize(FArchive& Ar, TArray<FReductionBaseSkeletalMeshBulkData*>& ReductionBaseSkeletalMeshDatas, UObject* Owner)")]
        public ITransferible Move2(Transfer transfer)
        {
            BulkData.Move2(transfer);
            return this;
        }
    }
}
