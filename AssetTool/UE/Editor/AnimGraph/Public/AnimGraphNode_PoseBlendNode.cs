namespace AssetTool
{
    [JsonAsset("AnimGraphNode_PoseBlendNode")]
    public class UAnimGraphNode_PoseBlendNode : UAnimGraphNode_PoseHandler
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}