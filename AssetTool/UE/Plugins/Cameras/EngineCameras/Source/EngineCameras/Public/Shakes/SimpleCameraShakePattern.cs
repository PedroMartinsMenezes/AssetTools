namespace AssetTool
{
    [JsonAsset("SimpleCameraShakePattern")]
    public class USimpleCameraShakePattern : UCameraShakePattern
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}