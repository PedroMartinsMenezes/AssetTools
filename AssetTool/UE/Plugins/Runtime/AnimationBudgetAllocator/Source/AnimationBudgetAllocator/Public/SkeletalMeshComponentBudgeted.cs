namespace AssetTool
{
    [JsonAsset("SkeletalMeshComponentBudgeted")]
    public class USkeletalMeshComponentBudgeted : USkeletalMeshComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}