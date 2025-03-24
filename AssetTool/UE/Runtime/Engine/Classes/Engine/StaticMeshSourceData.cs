namespace AssetTool
{
    [JsonAsset("StaticMeshDescriptionBulkData")]
    public class UStaticMeshDescriptionBulkData : UMeshDescriptionBaseBulkData
    {
        [Location("void FMeshDescriptionBulkData::Serialize( FArchive& Ar, UObject* Owner )")]
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    public class FStaticMeshSourceModel : ITransferible
    {
        public FRawMeshBulkData RawMeshBulkData;
        public FBool bIsValid;
        public UStaticMeshDescriptionBulkData StaticMeshDescriptionBulkData;

        [Location("void FStaticMeshSourceModel::SerializeBulkData(FArchive& Ar, UObject* Owner)")]
        public ITransferible Move(Transfer transfer)
        {
            if (!Supports.StaticMeshDeprecatedRawMesh)
            {
                transfer.Move(ref RawMeshBulkData);
            }
            else if (!Supports.SerializeMeshDescriptionBase)
            {
                transfer.Move(ref bIsValid);
                if (bIsValid)
                {
                    StaticMeshDescriptionBulkData ??= new();
                    StaticMeshDescriptionBulkData.BulkData ??= new();
                    StaticMeshDescriptionBulkData.BulkData.Move(transfer);
                }
            }
            return this;
        }
    }
}