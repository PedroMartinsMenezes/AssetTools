namespace AssetTool
{
    [JsonAsset("RigVMTemplateNode")]
    public class URigVMTemplateNode : URigVMNode
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}