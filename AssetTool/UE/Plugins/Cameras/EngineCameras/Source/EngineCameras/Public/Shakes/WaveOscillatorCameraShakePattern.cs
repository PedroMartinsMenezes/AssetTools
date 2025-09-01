namespace AssetTool
{
    [JsonAsset("WaveOscillatorCameraShakePattern")]
    public class UWaveOscillatorCameraShakePattern : USimpleCameraShakePattern
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}