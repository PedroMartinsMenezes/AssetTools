namespace AssetTool
{
    public class FStaticMeshSourceModel : ITransferable
    {
        public FRawMeshBulkData RawMeshBulkData;
        public FBool bIsValid;
        public UMeshDescriptionBaseBulkData StaticMeshDescriptionBulkData;

        [Location("void FStaticMeshSourceModel::SerializeBulkData(FArchive& Ar, UObject* Owner)")]
        public ITransferable Move(Transfer transfer)
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