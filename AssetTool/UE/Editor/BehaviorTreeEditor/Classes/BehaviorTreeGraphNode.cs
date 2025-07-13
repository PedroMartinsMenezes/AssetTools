namespace AssetTool
{
    [JsonAsset("BehaviorTreeGraphNode")]
    public class UBehaviorTreeGraphNode : UAIGraphNode
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}