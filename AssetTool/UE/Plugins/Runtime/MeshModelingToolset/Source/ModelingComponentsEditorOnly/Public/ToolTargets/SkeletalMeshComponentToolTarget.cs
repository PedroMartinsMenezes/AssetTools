namespace AssetTool
{
    [JsonAsset("SkeletalMeshComponentReadOnlyToolTarget")]
    public class USkeletalMeshComponentReadOnlyToolTarget : UPrimitiveComponentToolTarget
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("SkeletalMeshComponentToolTarget")]
    public class USkeletalMeshComponentToolTarget : USkeletalMeshComponentReadOnlyToolTarget
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("SkeletalMeshComponentReadOnlyToolTargetFactory")]
    public class USkeletalMeshComponentReadOnlyToolTargetFactory : UToolTargetFactory
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("SkeletalMeshComponentToolTargetFactory")]
    public class USkeletalMeshComponentToolTargetFactory : UToolTargetFactory
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}