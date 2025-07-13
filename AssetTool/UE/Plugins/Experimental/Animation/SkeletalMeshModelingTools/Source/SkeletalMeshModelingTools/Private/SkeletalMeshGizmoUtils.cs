namespace AssetTool
{
    [JsonAsset("SkeletalMeshGizmoWrapper")]
    public class USkeletalMeshGizmoWrapper : USkeletalMeshGizmoWrapperBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("SkeletalMeshGizmoContextObject")]
    public class USkeletalMeshGizmoContextObject : USkeletalMeshGizmoContextObjectBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}