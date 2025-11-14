namespace AssetTool
{
    [JsonAsset("StaticMeshComponentToolTarget")]
    public class UStaticMeshComponentToolTarget : UPrimitiveComponentToolTarget
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("StaticMeshComponentToolTargetFactory")]
    public class UStaticMeshComponentToolTargetFactory : UToolTargetFactory
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}