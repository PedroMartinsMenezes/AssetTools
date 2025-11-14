namespace AssetTool
{
    [JsonAsset("ControlRigBlueprint")]
    public class UControlRigBlueprint : URigVMBlueprint
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}