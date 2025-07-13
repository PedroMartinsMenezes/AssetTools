namespace AssetTool
{
    [JsonAsset("WaveformEditorWidgetsSettings")]
    public class UWaveformEditorWidgetsSettings : UDeveloperSettings
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}