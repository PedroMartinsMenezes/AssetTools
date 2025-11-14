namespace AssetTool
{
    [JsonAsset("StaticMeshToolTarget")]
    public class UStaticMeshToolTarget : UToolTarget
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("StaticMeshToolTargetFactory")]
    public class UStaticMeshToolTargetFactory : UToolTargetFactory
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}