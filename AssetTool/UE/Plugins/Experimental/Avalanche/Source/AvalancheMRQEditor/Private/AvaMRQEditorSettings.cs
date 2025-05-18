namespace AssetTool
{
    [JsonAsset("AvaMRQEditorSettings")]
    public class UAvaMRQEditorSettings : UDeveloperSettings
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}