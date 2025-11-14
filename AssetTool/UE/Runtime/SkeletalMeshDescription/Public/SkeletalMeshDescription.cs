namespace AssetTool
{
    [JsonAsset("SkeletalMeshDescription")]
    public class USkeletalMeshDescription : UMeshDescriptionBase
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}