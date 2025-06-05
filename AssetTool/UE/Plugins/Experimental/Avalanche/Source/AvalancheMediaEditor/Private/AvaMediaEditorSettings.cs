namespace AssetTool
{
    [JsonAsset("AvaMediaEditorSettings")]
    public class UAvaMediaEditorSettings : UDeveloperSettings
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}