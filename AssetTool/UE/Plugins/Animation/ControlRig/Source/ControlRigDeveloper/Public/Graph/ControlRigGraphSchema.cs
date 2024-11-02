namespace AssetTool
{
    [JsonAsset("ControlRigGraphSchema")]
    public class UControlRigGraphSchema : URigVMEdGraphSchema
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}