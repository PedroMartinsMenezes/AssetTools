namespace AssetTool
{
    [JsonAsset("RigVMAggregateNode")]
    public class URigVMAggregateNode : URigVMCollapseNode
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}