namespace AssetTool
{
    [JsonAsset("WaveformEditorTransformationsSettings")]
    public class UWaveformEditorTransformationsSettings : UDeveloperSettings
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}