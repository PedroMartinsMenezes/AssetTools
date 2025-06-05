namespace AssetTool
{
    [JsonAsset("StateTreeEditorSettings")]
    public class UStateTreeEditorSettings : UDeveloperSettings
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}