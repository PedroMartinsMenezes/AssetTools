namespace AssetTool
{
    [JsonAsset("ControlRigSchema")]
    public class UControlRigSchema : URigVMSchema
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}