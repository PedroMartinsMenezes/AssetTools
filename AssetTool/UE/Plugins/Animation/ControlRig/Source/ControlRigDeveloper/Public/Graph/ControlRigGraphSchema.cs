namespace AssetTool
{
    [JsonAsset("ControlRigGraphSchema")]
    public class UControlRigGraphSchema : URigVMEdGraphSchema
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}