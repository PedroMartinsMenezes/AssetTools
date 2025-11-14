namespace AssetTool
{
    [JsonAsset("AnimGraphNode_CustomTransitionResult")]
    public class UAnimGraphNode_CustomTransitionResult : UAnimGraphNode_StateResult
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}