namespace AssetTool
{
    [JsonAsset("SkeletonFactory")]
    public class USkeletonFactory : UFactory
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}