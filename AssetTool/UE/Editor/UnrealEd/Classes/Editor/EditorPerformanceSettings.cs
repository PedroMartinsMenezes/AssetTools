namespace AssetTool
{
    [JsonAsset("EditorPerformanceSettings")]
    public class UEditorPerformanceSettings : UDeveloperSettings
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}