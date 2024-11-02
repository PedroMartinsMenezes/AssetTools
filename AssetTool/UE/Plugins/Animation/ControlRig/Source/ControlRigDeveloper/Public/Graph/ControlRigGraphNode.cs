namespace AssetTool
{
    [JsonAsset("ControlRigGraphNode")]
    public class UControlRigGraphNode : URigVMEdGraphNode
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}