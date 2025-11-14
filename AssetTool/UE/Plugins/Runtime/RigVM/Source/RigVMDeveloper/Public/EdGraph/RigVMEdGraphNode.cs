namespace AssetTool
{
    [JsonAsset("RigVMEdGraphNode")]
    public class URigVMEdGraphNode : UEdGraphNode
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}