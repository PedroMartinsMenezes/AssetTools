namespace AssetTool
{
    [JsonAsset("StaticMeshComponentToolTarget")]
    public class UStaticMeshComponentToolTarget : UPrimitiveComponentToolTarget
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("StaticMeshComponentToolTargetFactory")]
    public class UStaticMeshComponentToolTargetFactory : UToolTargetFactory
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}