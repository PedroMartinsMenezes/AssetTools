namespace AssetTool
{
    [JsonAsset("RigVMEditorSettings")]
    public class URigVMEditorSettings : UDeveloperSettings
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}