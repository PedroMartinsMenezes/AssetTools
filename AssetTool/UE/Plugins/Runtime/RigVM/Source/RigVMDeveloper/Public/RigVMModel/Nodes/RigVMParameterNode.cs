namespace AssetTool
{
    [JsonAsset("RigVMParameterNode")]
    public class URigVMParameterNode : URigVMNode
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}