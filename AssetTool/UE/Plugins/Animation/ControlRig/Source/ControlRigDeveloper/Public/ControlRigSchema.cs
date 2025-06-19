namespace AssetTool
{
    [JsonAsset("ControlRigSchema")]
    public class UControlRigSchema : URigVMSchema
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}