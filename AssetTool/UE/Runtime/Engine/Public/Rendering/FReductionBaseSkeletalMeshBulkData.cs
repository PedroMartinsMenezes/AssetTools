namespace AssetTool
{
    public class FReductionBaseSkeletalMeshBulkData
    {
        public FByteBulkData BulkData = new();

        [Location("void FReductionBaseSkeletalMeshBulkData::Serialize(FArchive& Ar, TArray<FReductionBaseSkeletalMeshBulkData*>& ReductionBaseSkeletalMeshDatas, UObject* Owner)")]
        public void Move(Transfer transfer)
        {
            BulkData.Move(transfer);
        }
    }
}
