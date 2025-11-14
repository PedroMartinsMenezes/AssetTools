namespace AssetTool
{
    [JsonAsset("BehaviorTreeDecoratorGraphNode")]
    public class UBehaviorTreeDecoratorGraphNode : UEdGraphNode
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}