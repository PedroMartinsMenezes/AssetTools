namespace AssetTool
{
    [JsonAsset("BehaviorTreeGraphNode_SimpleParallel")]
    public class UBehaviorTreeGraphNode_SimpleParallel : UBehaviorTreeGraphNode_Composite
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}