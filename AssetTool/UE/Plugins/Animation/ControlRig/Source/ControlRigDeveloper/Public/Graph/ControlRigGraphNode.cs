namespace AssetTool
{
    [JsonAsset("ControlRigGraphNode")]
    public class UControlRigGraphNode : URigVMEdGraphNode
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}