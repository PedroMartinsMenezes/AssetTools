namespace AssetTool
{
    [JsonAsset("AvaTransitionEditorSettings")]
    public class UAvaTransitionEditorSettings : UDeveloperSettings
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}