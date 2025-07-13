namespace AssetTool
{
    [JsonAsset("EdGraphSchema_BehaviorTree")]
    public class UEdGraphSchema_BehaviorTree : UAIGraphSchema
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}