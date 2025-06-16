namespace AssetTool
{
    [JsonAsset("EditorPerformanceSettings")]
    public class UEditorPerformanceSettings : UDeveloperSettings
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}