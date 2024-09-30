namespace AssetTool
{
    public class FReductionBaseSkeletalMeshBulkData : ITransferible
    {
        public FByteBulkData BulkData = new();

        [Location("void FReductionBaseSkeletalMeshBulkData::Serialize(FArchive& Ar, TArray<FReductionBaseSkeletalMeshBulkData*>& ReductionBaseSkeletalMeshDatas, UObject* Owner)")]
        public ITransferible Move(Transfer transfer)
        {
            BulkData.Move(transfer);
            return this;
        }
    }
}
