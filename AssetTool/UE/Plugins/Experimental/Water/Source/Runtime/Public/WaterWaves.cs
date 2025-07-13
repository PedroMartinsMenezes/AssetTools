namespace AssetTool
{
    [JsonAsset("WaterWavesBase")]
    public class UWaterWavesBase : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("WaterWaves")]
    public class UWaterWaves : UWaterWavesBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("WaterWavesAsset")]
    public class UWaterWavesAsset : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("WaterWavesAssetReference")]
    public class UWaterWavesAssetReference : UWaterWavesBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}