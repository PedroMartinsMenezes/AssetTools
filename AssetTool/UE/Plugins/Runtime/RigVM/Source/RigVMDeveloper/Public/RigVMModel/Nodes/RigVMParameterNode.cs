namespace AssetTool
{
    [JsonAsset("RigVMParameterNode")]
    public class URigVMParameterNode : URigVMNode
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}