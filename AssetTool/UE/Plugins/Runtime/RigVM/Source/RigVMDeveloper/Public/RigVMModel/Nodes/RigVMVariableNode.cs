namespace AssetTool
{
    [JsonAsset("RigVMVariableNode")]
    public class URigVMVariableNode : URigVMNode
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}