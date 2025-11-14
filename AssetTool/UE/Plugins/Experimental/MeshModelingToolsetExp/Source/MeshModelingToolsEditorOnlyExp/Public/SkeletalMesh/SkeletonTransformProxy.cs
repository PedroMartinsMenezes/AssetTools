namespace AssetTool
{
    [JsonAsset("SkeletonTransformProxy")]
    public class USkeletonTransformProxy : UTransformProxy
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}