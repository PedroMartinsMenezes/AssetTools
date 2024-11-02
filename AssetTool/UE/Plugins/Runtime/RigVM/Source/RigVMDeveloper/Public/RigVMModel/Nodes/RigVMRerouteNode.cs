namespace AssetTool
{
    [JsonAsset("RigVMRerouteNode")]
    public class URigVMRerouteNode : URigVMNode
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}