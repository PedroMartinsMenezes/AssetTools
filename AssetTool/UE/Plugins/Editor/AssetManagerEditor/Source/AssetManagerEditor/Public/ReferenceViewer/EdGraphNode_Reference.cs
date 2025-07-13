namespace AssetTool
{
    [JsonAsset("EdGraphNode_Reference")]
    public class UEdGraphNode_Reference : UEdGraphNode
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}