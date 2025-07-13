namespace AssetTool
{
    [JsonAsset("BehaviorTreeGraphNode_SimpleParallel")]
    public class UBehaviorTreeGraphNode_SimpleParallel : UBehaviorTreeGraphNode_Composite
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}