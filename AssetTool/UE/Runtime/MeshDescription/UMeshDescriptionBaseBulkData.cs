namespace AssetTool
{
    [Location("void UMeshDescriptionBaseBulkData::Serialize(FArchive& Ar)")]
    public class UMeshDescriptionBaseBulkData : UObject
    {
        public FMeshDescriptionBulkData BulkData = new();

        public override UObject Move(Transfer transfer)
        {
            base.Move(transfer);
            BulkData.Move(transfer);
            return this;
        }
    }
}
