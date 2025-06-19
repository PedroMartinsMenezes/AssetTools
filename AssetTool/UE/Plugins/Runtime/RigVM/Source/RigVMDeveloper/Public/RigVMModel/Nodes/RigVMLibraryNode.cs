namespace AssetTool
{
    [JsonAsset("RigVMLibraryNode")]
    public class URigVMLibraryNode : URigVMTemplateNode
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}