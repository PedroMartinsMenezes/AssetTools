namespace AssetTool
{
    [JsonAsset("SkeletalMeshReadOnlyToolTarget")]
    public class USkeletalMeshReadOnlyToolTarget : UToolTarget
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("SkeletalMeshToolTarget")]
    public class USkeletalMeshToolTarget : USkeletalMeshReadOnlyToolTarget
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("SkeletalMeshReadOnlyToolTargetFactory")]
    public class USkeletalMeshReadOnlyToolTargetFactory : UToolTargetFactory
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("SkeletalMeshToolTargetFactory")]
    public class USkeletalMeshToolTargetFactory : UToolTargetFactory
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}