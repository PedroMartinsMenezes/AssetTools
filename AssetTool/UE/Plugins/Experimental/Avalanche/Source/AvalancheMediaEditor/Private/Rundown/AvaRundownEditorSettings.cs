namespace AssetTool
{
    [JsonAsset("AvaRundownEditorSettings")]
    public class UAvaRundownEditorSettings : UDeveloperSettings
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}