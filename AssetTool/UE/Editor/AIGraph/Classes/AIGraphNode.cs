namespace AssetTool
{
    [JsonAsset("AIGraphNode")]
    public class UAIGraphNode : UEdGraphNode
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}