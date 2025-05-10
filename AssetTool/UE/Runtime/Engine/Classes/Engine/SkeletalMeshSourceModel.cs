namespace AssetTool
{
    [JsonAsset("SkeletalMeshDescriptionBulkData")]
    public class USkeletalMeshDescriptionBulkData : UMeshDescriptionBaseBulkData
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}