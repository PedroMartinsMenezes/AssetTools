namespace AssetTool
{
    [JsonAsset("RigVMDispatchNode")]
    public class URigVMDispatchNode : URigVMTemplateNode
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}