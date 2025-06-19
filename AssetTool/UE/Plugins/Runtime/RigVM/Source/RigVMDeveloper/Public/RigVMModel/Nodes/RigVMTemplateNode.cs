namespace AssetTool
{
    [JsonAsset("RigVMTemplateNode")]
    public class URigVMTemplateNode : URigVMNode
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}