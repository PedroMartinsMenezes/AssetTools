namespace AssetTool
{
    [JsonAsset("SkeletonTransformProxy")]
    public class USkeletonTransformProxy : UTransformProxy
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}