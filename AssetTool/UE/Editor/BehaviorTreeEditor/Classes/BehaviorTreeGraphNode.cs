namespace AssetTool
{
    [JsonAsset("BehaviorTreeGraphNode")]
    public class UBehaviorTreeGraphNode : UAIGraphNode
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}