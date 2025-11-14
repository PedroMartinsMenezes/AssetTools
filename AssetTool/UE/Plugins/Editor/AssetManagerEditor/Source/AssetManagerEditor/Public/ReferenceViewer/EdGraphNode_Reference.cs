namespace AssetTool
{
    [JsonAsset("EdGraphNode_Reference")]
    public class UEdGraphNode_Reference : UEdGraphNode
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}