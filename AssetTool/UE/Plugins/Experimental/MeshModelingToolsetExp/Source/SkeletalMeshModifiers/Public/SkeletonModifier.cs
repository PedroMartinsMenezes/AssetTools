namespace AssetTool
{
    [JsonAsset("SkeletonModifier")]
    public class USkeletonModifier : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("SkeletalMeshMergeOptions")]
    public class USkeletalMeshMergeOptions : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}