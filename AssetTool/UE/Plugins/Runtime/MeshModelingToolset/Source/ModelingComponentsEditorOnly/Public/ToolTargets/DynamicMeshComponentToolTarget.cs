namespace AssetTool
{
    [JsonAsset("DynamicMeshComponentToolTarget")]
    public class UDynamicMeshComponentToolTarget : UPrimitiveComponentToolTarget
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("DynamicMeshComponentToolTargetFactory")]
    public class UDynamicMeshComponentToolTargetFactory : UToolTargetFactory
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}