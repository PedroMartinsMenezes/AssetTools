namespace AssetTool
{
    [JsonAsset("AvaRundownEditorSettings")]
    public class UAvaRundownEditorSettings : UDeveloperSettings
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}