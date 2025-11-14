namespace AssetTool
{
    [JsonAsset("SkeletalMeshDescriptionBulkData")]
    public class USkeletalMeshDescriptionBulkData : UMeshDescriptionBaseBulkData
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}