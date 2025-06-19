namespace AssetTool
{
    [JsonAsset("InterchangeSkeletonFactory")]
    public class UInterchangeSkeletonFactory : UInterchangeFactoryBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}