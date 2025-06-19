namespace AssetTool
{
    [JsonAsset("PrimitiveComponentToolTarget")]
    public class UPrimitiveComponentToolTarget : UToolTarget
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("PrimitiveComponentToolTargetFactory")]
    public class UPrimitiveComponentToolTargetFactory : UToolTargetFactory
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}