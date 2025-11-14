namespace AssetTool
{
    [JsonAsset("EdGraphNode_Comment")]
    public class UEdGraphNode_Comment : UEdGraphNode
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}