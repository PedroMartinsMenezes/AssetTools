namespace AssetTool
{
    [JsonAsset("ControlRigSettings")]
    public class UControlRigSettings : UDeveloperSettings
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("ControlRigEditorSettings")]
    public class UControlRigEditorSettings : URigVMEditorSettings
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}