namespace AssetTool
{
    [JsonAsset("AnimGraphNode_PoseDriver")]
    public class UAnimGraphNode_PoseDriver : UAnimGraphNode_PoseHandler
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}