namespace AssetTool
{
    [JsonAsset("AnimGraphNode_LocalRefPose")]
    public class UAnimGraphNode_LocalRefPose : UAnimGraphNode_RefPoseBase
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}