namespace AssetTool
{
    [JsonAsset("AIGraphNode")]
    public class UAIGraphNode : UEdGraphNode
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}