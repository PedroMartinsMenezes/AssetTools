namespace AssetTool
{
    [JsonAsset("AIGraphNode")]
    public class UAIGraphNode : UEdGraphNode
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}