namespace AssetTool
{
    [JsonAsset("PlayerViewportCompositingOutput")]
    public class UPlayerViewportCompositingOutput : UColorConverterOutputPass
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("PlayerCompOutputCameraModifier")]
    public class UPlayerCompOutputCameraModifier : UCameraModifier
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}