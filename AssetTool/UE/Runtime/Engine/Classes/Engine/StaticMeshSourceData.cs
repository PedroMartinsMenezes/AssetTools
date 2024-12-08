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
}