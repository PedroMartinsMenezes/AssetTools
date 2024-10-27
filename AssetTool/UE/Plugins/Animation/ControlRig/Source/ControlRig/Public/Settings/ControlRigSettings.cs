namespace AssetTool
{
    [JsonAsset("ControlRigSettings")]
    public class  UControlRigSettings : UDeveloperSettings
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("ControlRigEditorSettings")]
    public class  UControlRigEditorSettings : URigVMEditorSettings
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}