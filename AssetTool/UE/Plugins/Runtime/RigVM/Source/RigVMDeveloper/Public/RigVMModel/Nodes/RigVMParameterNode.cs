namespace AssetTool
{
    [JsonAsset("RigVMParameterNode")]
    public class URigVMParameterNode : URigVMNode
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}