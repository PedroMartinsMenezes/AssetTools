namespace AssetTool
{
    [JsonAsset("RigVMAggregateNode")]
    public class URigVMAggregateNode : URigVMCollapseNode
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}