namespace AssetTool
{
    [JsonAsset("ControlRigSettings")]
    public class UControlRigSettings : UDeveloperSettings
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("ControlRigEditorSettings")]
    public class UControlRigEditorSettings : URigVMEditorSettings
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}