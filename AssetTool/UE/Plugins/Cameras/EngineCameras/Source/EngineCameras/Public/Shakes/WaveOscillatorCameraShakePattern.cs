namespace AssetTool
{
    [JsonAsset("WaveOscillatorCameraShakePattern")]
    public class UWaveOscillatorCameraShakePattern : USimpleCameraShakePattern
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}