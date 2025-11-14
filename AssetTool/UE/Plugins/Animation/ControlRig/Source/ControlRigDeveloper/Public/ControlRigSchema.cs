namespace AssetTool
{
    [JsonAsset("ControlRigSchema")]
    public class UControlRigSchema : URigVMSchema
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}