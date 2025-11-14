namespace AssetTool
{
    [JsonAsset("RigVMAggregateNode")]
    public class URigVMAggregateNode : URigVMCollapseNode
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}