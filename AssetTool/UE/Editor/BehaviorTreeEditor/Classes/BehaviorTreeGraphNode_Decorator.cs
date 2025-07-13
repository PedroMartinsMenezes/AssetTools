namespace AssetTool
{
    [JsonAsset("BehaviorTreeGraphNode_Decorator")]
    public class UBehaviorTreeGraphNode_Decorator : UBehaviorTreeGraphNode
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}