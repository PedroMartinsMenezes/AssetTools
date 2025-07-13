namespace AssetTool
{
    [JsonAsset("SkeletalMeshComponentBudgeted")]
    public class USkeletalMeshComponentBudgeted : USkeletalMeshComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}