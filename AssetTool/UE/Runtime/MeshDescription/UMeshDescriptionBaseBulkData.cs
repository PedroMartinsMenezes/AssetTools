namespace AssetTool
{
    public class UMeshDescriptionBaseBulkData : UObject
    {
        public FMeshDescriptionBulkData BulkData;

        [Location("void UMeshDescriptionBaseBulkData::Serialize(FArchive& Ar)")]
        public override UObject Move(Transfer transfer)
        {
            base.Move(transfer);
            transfer.Move(ref BulkData);
            return this;
        }
    }
}
