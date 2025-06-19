namespace AssetTool
{
    [JsonAsset("SkeletalMeshDescriptionBulkData")]
    public class USkeletalMeshDescriptionBulkData : UMeshDescriptionBaseBulkData
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}