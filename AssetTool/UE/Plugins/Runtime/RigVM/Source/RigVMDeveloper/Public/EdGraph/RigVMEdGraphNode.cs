namespace AssetTool
{
    [JsonAsset("RigVMEdGraphNode")]
    public class URigVMEdGraphNode : UEdGraphNode
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}