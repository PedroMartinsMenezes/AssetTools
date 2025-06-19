namespace AssetTool
{
    public class FReductionBaseSkeletalMeshBulkData : ITransferible
    {
        public FByteBulkData BulkData;

        [Location("void FReductionBaseSkeletalMeshBulkData::Serialize(FArchive& Ar, TArray<FReductionBaseSkeletalMeshBulkData*>& ReductionBaseSkeletalMeshDatas, UObject* Owner)")]
        public ITransferible Move(Transfer transfer)
        {
            transfer.Move(ref BulkData);
            return this;
        }
    }
}
