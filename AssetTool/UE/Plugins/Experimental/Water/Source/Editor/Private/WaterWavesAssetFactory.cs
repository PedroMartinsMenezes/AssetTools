namespace AssetTool
{
    [JsonAsset("WaterWavesAssetFactory")]
    public class UWaterWavesAssetFactory : UFactory
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}