namespace AssetTool
{
    [JsonAsset("TG_EdGraphNode")]
    public class UTG_EdGraphNode : UEdGraphNode
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}