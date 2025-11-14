namespace AssetTool
{
    [JsonAsset("PerlinNoiseCameraShakePattern")]
    public class UPerlinNoiseCameraShakePattern : USimpleCameraShakePattern
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}