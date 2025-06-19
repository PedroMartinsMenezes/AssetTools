namespace AssetTool
{
    [JsonAsset("RigVMEditorSettings")]
    public class URigVMEditorSettings : UDeveloperSettings
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}