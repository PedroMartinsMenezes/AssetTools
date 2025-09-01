namespace AssetTool
{
    [JsonAsset("PerlinNoiseCameraShakePattern")]
    public class UPerlinNoiseCameraShakePattern : USimpleCameraShakePattern
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}