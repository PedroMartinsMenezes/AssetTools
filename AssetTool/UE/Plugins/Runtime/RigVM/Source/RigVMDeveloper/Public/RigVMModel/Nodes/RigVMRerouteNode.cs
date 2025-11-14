namespace AssetTool
{
    [JsonAsset("RigVMRerouteNode")]
    public class URigVMRerouteNode : URigVMNode
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}