namespace AssetTool
{
    [JsonAsset("K2Node")]
    public class UK2Node : UEdGraphNode
    {
        [Location("void UK2Node::Serialize(FArchive& Ar)")]
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
