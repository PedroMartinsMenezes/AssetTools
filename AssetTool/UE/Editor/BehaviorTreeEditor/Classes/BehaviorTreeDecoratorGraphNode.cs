namespace AssetTool
{
    [JsonAsset("BehaviorTreeDecoratorGraphNode")]
    public class UBehaviorTreeDecoratorGraphNode : UEdGraphNode
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}