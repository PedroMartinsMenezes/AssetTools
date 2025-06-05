namespace AssetTool
{
    [JsonAsset("AnimGraphNode_PoseDriver")]
    public class UAnimGraphNode_PoseDriver : UAnimGraphNode_PoseHandler
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}