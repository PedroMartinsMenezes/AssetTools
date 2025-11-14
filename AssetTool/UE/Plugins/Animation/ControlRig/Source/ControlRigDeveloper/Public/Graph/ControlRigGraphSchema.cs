namespace AssetTool
{
    [JsonAsset("ControlRigGraphSchema")]
    public class UControlRigGraphSchema : URigVMEdGraphSchema
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}