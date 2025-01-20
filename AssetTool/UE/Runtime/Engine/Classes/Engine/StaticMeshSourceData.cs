namespace AssetTool
{
    [JsonAsset("StaticMeshDescriptionBulkData")]
    public class UStaticMeshDescriptionBulkData : UMeshDescriptionBaseBulkData
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    public class FStaticMeshSourceModel : ITransferible
    {
        public FRawMeshBulkData RawMeshBulkData;
        public FBool bIsValid;
        public UInt32 StaticMeshDescriptionBulkData;

        public bool IsEmpty() => RawMeshBulkData is null && bIsValid is null && StaticMeshDescriptionBulkData == 0;

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
                    transfer.Move(ref RawMeshBulkData);
                }
            }
            return this;
        }
    }
}