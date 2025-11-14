namespace AssetTool
{
    [JsonAsset("OptimusSkeletalMeshComponentSource")]
    public class UOptimusSkeletalMeshComponentSource : UOptimusSkinnedMeshComponentSource
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}