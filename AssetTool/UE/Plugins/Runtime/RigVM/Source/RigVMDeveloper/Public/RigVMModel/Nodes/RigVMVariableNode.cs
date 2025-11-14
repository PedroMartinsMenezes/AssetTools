namespace AssetTool
{
    [JsonAsset("RigVMVariableNode")]
    public class URigVMVariableNode : URigVMNode
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}