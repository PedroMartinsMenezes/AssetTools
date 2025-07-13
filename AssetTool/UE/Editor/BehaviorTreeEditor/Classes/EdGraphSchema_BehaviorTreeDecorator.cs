namespace AssetTool
{
    [JsonAsset("EdGraphSchema_BehaviorTreeDecorator")]
    public class UEdGraphSchema_BehaviorTreeDecorator : UEdGraphSchema
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}