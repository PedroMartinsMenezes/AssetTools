namespace AssetTool
{
    [JsonAsset("GerstnerWaterWaveGeneratorBase")]
    public class UGerstnerWaterWaveGeneratorBase : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("GerstnerWaterWaveGeneratorSimple")]
    public class UGerstnerWaterWaveGeneratorSimple : UGerstnerWaterWaveGeneratorBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("GerstnerWaterWaveGeneratorSpectrum")]
    public class UGerstnerWaterWaveGeneratorSpectrum : UGerstnerWaterWaveGeneratorBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("GerstnerWaterWaves")]
    public class UGerstnerWaterWaves : UWaterWaves
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}