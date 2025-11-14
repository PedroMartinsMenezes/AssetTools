namespace AssetTool
{
    [JsonAsset("ControlRigGraphNode")]
    public class UControlRigGraphNode : URigVMEdGraphNode
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}