namespace AssetTool
{
    [JsonAsset("RigVMRerouteNode")]
    public class URigVMRerouteNode : URigVMNode
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}