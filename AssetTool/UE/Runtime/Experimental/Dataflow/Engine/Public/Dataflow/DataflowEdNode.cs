namespace AssetTool
{
    [JsonAsset("DataflowEdNode")]
    public class UDataflowEdNode : UEdGraphNode
    {
        public FGuid DataflowNodeGuid;

        [Location("void UDataflowEdNode::Serialize(FArchive& Ar)")]
        public override ITransferible Move(Transfer transfer)
        {
            base.Move(transfer);
            transfer.Move(ref DataflowNodeGuid);
            return this;
        }
    }
}