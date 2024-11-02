namespace AssetTool
{
    [JsonAsset("ControlRigBlueprint")]
    public class UControlRigBlueprint : URigVMBlueprint
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}