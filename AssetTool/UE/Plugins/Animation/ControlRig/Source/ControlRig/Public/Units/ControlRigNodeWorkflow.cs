namespace AssetTool
{
    [JsonAsset("ControlRigWorkflowOptions")]
    public class UControlRigWorkflowOptions : URigVMUserWorkflowOptions
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("ControlRigTransformWorkflowOptions")]
    public class UControlRigTransformWorkflowOptions : UControlRigWorkflowOptions
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}