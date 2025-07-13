namespace AssetTool
{
    [JsonAsset("AnimGraphNode_RigidBodyWithControl")]
    public class UAnimGraphNode_RigidBodyWithControl : UAnimGraphNode_SkeletalControlBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}