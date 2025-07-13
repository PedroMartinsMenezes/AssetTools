namespace AssetTool
{
    [JsonAsset("SkeletalMeshDescription")]
    public class USkeletalMeshDescription : UMeshDescriptionBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}