namespace AssetTool
{
    [JsonAsset("OptimusSkeletalMeshComponentSource")]
    public class UOptimusSkeletalMeshComponentSource : UOptimusSkinnedMeshComponentSource
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}