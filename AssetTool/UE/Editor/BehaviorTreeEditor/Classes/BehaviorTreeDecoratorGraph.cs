namespace AssetTool
{
    [JsonAsset("BehaviorTreeDecoratorGraph")]
    public class UBehaviorTreeDecoratorGraph : UEdGraph
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}