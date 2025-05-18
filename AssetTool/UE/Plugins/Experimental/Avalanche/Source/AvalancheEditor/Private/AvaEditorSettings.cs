namespace AssetTool
{
    [JsonAsset("AvaEditorSettings")]
    public class UAvaEditorSettings : UDeveloperSettings
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}