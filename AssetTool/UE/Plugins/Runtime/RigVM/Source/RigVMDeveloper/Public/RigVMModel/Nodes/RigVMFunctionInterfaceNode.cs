namespace AssetTool
{
    [JsonAsset("RigVMFunctionInterfaceNode")]
    public class URigVMFunctionInterfaceNode : URigVMTemplateNode
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}