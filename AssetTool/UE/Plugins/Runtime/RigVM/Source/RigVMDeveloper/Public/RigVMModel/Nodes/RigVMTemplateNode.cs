namespace AssetTool
{
    [JsonAsset("RigVMTemplateNode")]
    public class URigVMTemplateNode : URigVMNode
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}