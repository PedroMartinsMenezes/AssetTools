namespace AssetTool
{
    [JsonAsset("RigVMVariableNode")]
    public class URigVMVariableNode : URigVMNode
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}