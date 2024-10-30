namespace AssetTool
{
    [JsonAsset("RigVMEditorSettings")]
    public class URigVMEditorSettings : UDeveloperSettings
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}