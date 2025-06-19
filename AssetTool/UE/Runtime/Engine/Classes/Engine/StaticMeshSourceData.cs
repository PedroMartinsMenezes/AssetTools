namespace AssetTool
{
    [JsonAsset("StaticMeshDescriptionBulkData")]
    public class UStaticMeshDescriptionBulkData : UMeshDescriptionBaseBulkData
    {
        [Location("void FMeshDescriptionBulkData::Serialize( FArchive& Ar, UObject* Owner )")]
        public override ITransferible Move(Transfer transfer)
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
            if (!transfer.Supports.StaticMeshDeprecatedRawMesh)
            {
                transfer.Move(ref RawMeshBulkData);
            }
            else if (!transfer.Supports.SerializeMeshDescriptionBase)
            {
                transfer.Move(ref bIsValid);
                if (bIsValid)
                {
                    transfer.Move(ref StaticMeshDescriptionBulkData, (x) => x.MoveBulkData(transfer));
                }
            }
            return this;
        }
    }
}