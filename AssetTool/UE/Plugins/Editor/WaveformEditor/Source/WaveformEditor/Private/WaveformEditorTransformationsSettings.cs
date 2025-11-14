namespace AssetTool
{
    [JsonAsset("WaveformEditorTransformationsSettings")]
    public class UWaveformEditorTransformationsSettings : UDeveloperSettings
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}