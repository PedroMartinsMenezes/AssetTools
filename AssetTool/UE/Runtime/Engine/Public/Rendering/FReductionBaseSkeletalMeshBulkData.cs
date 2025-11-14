namespace AssetTool
{
    public class FReductionBaseSkeletalMeshBulkData : ITransferable
    {
        public FByteBulkData BulkData;

        [Location("void FReductionBaseSkeletalMeshBulkData::Serialize(FArchive& Ar, TArray<FReductionBaseSkeletalMeshBulkData*>& ReductionBaseSkeletalMeshDatas, UObject* Owner)")]
        public ITransferable Move(Transfer transfer)
        {
            transfer.Move(ref BulkData);
            return this;
        }
    }
}
