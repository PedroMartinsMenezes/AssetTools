namespace AssetTool
{
    [JsonAsset("SimpleCameraShakePattern")]
    public class USimpleCameraShakePattern : UCameraShakePattern
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}