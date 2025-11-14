namespace AssetTool
{
    [JsonAsset("EditorPerformanceSettings")]
    public class UEditorPerformanceSettings : UDeveloperSettings
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}