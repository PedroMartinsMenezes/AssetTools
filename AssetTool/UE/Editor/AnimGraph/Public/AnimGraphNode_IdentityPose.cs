namespace AssetTool
{
    [JsonAsset("AnimGraphNode_IdentityPose")]
    public class UAnimGraphNode_IdentityPose : UAnimGraphNode_RefPoseBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}